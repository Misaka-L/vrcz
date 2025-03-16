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
using VRCZ.Desktop.ViewModels.Views.Dialogs;
using VRCZ.Desktop.Views.ProfileDialog;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Desktop.ViewModels.Views;

public partial class ProfileSelectionViewModel(
    UserProfileService userProfileService,
    RemoteImageLoadService remoteImageLoadService,
    ManagedUserProfileService managedUserProfileService,
    VRChatAuthService vrchatAuthService,
    IServiceProvider serviceProvider) : ViewModelBase
{
    [ObservableProperty] private UserProfileItemViewModel[] _profiles = [];

    [ObservableProperty] private string? _errorMessage;

    [RelayCommand]
    private async Task LoadProfiles()
    {
        var profiles = await userProfileService.GetProfilesAsync();

        Profiles = profiles
            .Select(profile =>
                new UserProfileItemViewModel(profile, remoteImageLoadService, managedUserProfileService, HandleTwoFactor))
            .ToArray();

        foreach (var userProfileItemViewModel in Profiles)
        {
            userProfileItemViewModel.ErrorOccured += (_, exception) =>
            {
                if (exception is Error { ErrorProp: not null } apiError)
                {
                    ErrorMessage = apiError.ErrorProp.Message;
                    return;
                }

                ErrorMessage = exception.ToString();
            };
        }
    }

    private async Task HandleTwoFactor(TwoFactorRequired_requiresTwoFactorAuth[] availableTwoFactor)
    {
        await OverlayDialog.ShowModal(new DialogOtpView(), new DialogOtpViewModel(async (code, method) =>
        {
            var result = await vrchatAuthService.VerifyTwoFactorAsync(code, method);

            if (!result)
            {
                throw new InvalidOperationException("Invalid OTP/TOTP code");
            }
        }), options: new OverlayDialogOptions
        {
            Buttons = DialogButton.None,
            CanDragMove = false,
            CanResize = false,
            Title = "Two-factor Authentication"
        });
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
