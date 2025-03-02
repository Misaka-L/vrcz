namespace VRCZ.Core.Services;

public class ManagedUserProfileService(
    VRChatPipelineService vrchatPipelineService,
    VRChatAuthService vrchatAuthService,
    UserProfileService userProfileService)
{
    public async Task LoadProfileAsync(string userId)
    {
        try
        {
            await userProfileService.LoadProfileAsync(userId);
            await vrchatAuthService.UpdateProfileForCurrentAccountAsync();
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
