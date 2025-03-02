using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VRCZ.Core.Services;

public class UserProfileHostService(
    UserProfileService userProfileService,
    VRChatPipelineService vrchatPipelineService)
    : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        userProfileService.ProfileChanged += OnProfileChanged;
        return Task.CompletedTask;
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await userProfileService.SaveProfileAsync();
        await vrchatPipelineService.DisconnectAsync();
    }

    private async void OnProfileChanged(object? sender, EventArgs e)
    {
        try
        {
            await vrchatPipelineService.DisconnectAsync();

            if (userProfileService.IsProfileLoaded)
            {
                await vrchatPipelineService.ConnectAsync();
            }
        }
        catch
        {
        }
    }
}
