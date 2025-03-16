using VRCZ.Core.Exceptions;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Services;

public class ManagedUserProfileService(
    VRChatPipelineService vrchatPipelineService,
    VRChatAuthService vrchatAuthService,
    UserProfileService userProfileService)
{
    public async Task LoadProfileAsync(string userId,
        Func<TwoFactorRequired_requiresTwoFactorAuth[], Task>? handleTwoFactorRequired = null)
    {
        try
        {
            await userProfileService.LoadProfileAsync(userId);

            try
            {
                await vrchatAuthService.UpdateProfileForCurrentAccountAsync();
            }
            catch (RequireRefreshTwoFactorException requireRefreshTwoFactorException)
            {
                if (handleTwoFactorRequired is null) throw;

                await handleTwoFactorRequired(requireRefreshTwoFactorException.AvailableTwoFactor);

                await vrchatAuthService.UpdateProfileForCurrentAccountAsync();
            }

            await vrchatPipelineService.ConnectAsync();
        }
        catch
        {
            if (userProfileService.IsProfileLoaded)
            {
                await userProfileService.UnloadProfileAsync();
            }

            throw;
        }
    }
}
