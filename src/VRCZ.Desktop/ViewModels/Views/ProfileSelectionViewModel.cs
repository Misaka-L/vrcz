using System;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Ursa.Controls;
using VRCZ.Core.Services;
using VRCZ.Desktop.Dialogs;
using VRCZ.Desktop.Services;
using VRCZ.Desktop.ViewModels.Dialogs;

namespace VRCZ.Desktop.ViewModels.Views;

public partial class ProfileSelectionViewModel(
    UserProfileService userProfileService,
    RemoteImageLoadService remoteImageLoadService,
    IServiceProvider serviceProvider) : ViewModelBase
{
    [ObservableProperty] private UserProfileItemViewModel[] _profiles = [];

    [RelayCommand]
    private async Task LoadProfiles()
    {
        var profiles = await userProfileService.GetProfilesAsync();

        Profiles = profiles
            .Select(profile => new UserProfileItemViewModel(profile, remoteImageLoadService, userProfileService))
            .ToArray();
    }

    [RelayCommand]
    private async Task CreateProfile()
    {
        var createProfileDialogViewModel = serviceProvider.GetRequiredService<CreateProfileDialogViewModel>();

        await OverlayDialog.ShowModal<CreateProfileDialog, CreateProfileDialogViewModel>(createProfileDialogViewModel,
            options: new OverlayDialogOptions
            {
                Buttons = DialogButton.None,
                CanDragMove = false,
                CanResize = false,
                Title = "Login your VRChat account"
            });
    }
}
