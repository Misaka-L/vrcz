using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
using VRCZ.Core.Exceptions;
using VRCZ.Core.Models;
using VRCZ.VRChatApi.Generated;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Services;

public class VRChatAuthService(UserProfileService userProfileService, VRChatApiClient vrchatApiClient)
{
    /// <summary>
    /// Login
    /// </summary>
    /// <param name="username">Username or Email</param>
    /// <param name="password">Password</param>
    /// <returns>User Information</returns>
    /// <exception cref="UnexpectedApiBehaviourException">Unexpected Api Behaviour</exception>
    /// <exception cref="Error">Api Error (e.g. Password is wrong or too many session)</exception>
    public async Task<LoginResult> LoginAsync(string username, string password)
    {
        var token = Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{Uri.EscapeDataString(username)}:{Uri.EscapeDataString(password)}"));

        var headersInspectionHandler = new HeadersInspectionHandlerOption()
        {
            InspectResponseHeaders = true
        };

        var result = await vrchatApiClient.Auth.User.GetAsUserGetResponseAsync(config =>
        {
            config.Headers.Add("Authorization", $"Basic {token}");

            config.Options.Add(headersInspectionHandler);
        });

        if (result is null)
            throw new UnexpectedApiBehaviourException("Auth User endpoint response null body");

        if (result.CurrentUser is not null)
            return new LoginResult(LoginResultType.Success);

        if (result.TwoFactorRequired is not null)
        {
            var availableMethods = result.TwoFactorRequired.RequiresTwoFactorAuth?
                .Where(method => method is not null)
                .OfType<TwoFactorRequired_requiresTwoFactorAuth>()
                .ToArray() ?? [];

            return new LoginResult(LoginResultType.TwoFactorRequired, availableMethods);
        }

        throw new UnexpectedApiBehaviourException("Auth User endpoint response null body");
    }

    public async Task<bool> VerifyTotpAsync(string code)
    {
        var verifyResult = await vrchatApiClient.Auth.Twofactorauth.Totp.Verify.PostAsync(
            new TwoFactorAuthCode
            {
                Code = code
            });

        if (verifyResult?.Verified is not { } verified)
            throw new UnexpectedApiBehaviourException("Auth Twofactorauth Totp Verify endpoint response null body");

        return verified;
    }

    public async Task CreateProfileForCurrentAccountAsync()
    {
        var userResponse = await vrchatApiClient.Auth.User.GetAsUserGetResponseAsync();

        if (userResponse?.CurrentUser?.Id is null)
            throw new InvalidOperationException("Not logged in");

        if (userResponse.CurrentUser.DisplayName is null)
            throw new UnexpectedApiBehaviourException("User DisplayName is null");

        // You can still get current user's username
#pragma warning disable CS0618
        if (userResponse.CurrentUser.Username is null)
#pragma warning restore CS0618
            throw new UnexpectedApiBehaviourException("User Username is null");

        if (userResponse.CurrentUser.CurrentAvatarImageUrl is null)
            throw new UnexpectedApiBehaviourException("User CurrentAvatarImageUrl is null");

        var profileId = userResponse.CurrentUser.Id;

#pragma warning disable CS0618
        await userProfileService.CreateProfileAsync(profileId, userResponse.CurrentUser.Username,
            userResponse.CurrentUser.DisplayName,
            userResponse.CurrentUser.CurrentAvatarImageUrl);
#pragma warning restore CS0618

        await userProfileService.LoadProfileAsync(profileId);
    }
}
