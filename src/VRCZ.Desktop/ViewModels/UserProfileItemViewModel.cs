using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.Input;
using VRCZ.Core.Models;
using VRCZ.Core.Services;
using VRCZ.Desktop.Services;

namespace VRCZ.Desktop.ViewModels;

public partial class UserProfileItemViewModel(
    UserProfile userProfile,
    RemoteImageLoadService remoteImageLoadService,
    UserProfileService userProfileService,
    VRChatAuthService vrchatAuthService) : ViewModelBase
{
    public UserProfile UserProfile => userProfile;
    public Task<Bitmap?> ProfileImage => remoteImageLoadService.LoadImageAsync(UserProfile.AvatarUrl);

    [RelayCommand]
    private async Task LoadProfile()
    {
        await userProfileService.LoadProfileAsync(UserProfile.Id);
        await vrchatAuthService.UpdateProfileForCurrentAccountAsync();
    }
}
