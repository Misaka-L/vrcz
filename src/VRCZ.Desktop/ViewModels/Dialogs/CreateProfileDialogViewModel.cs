using System.Threading.Tasks;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;
using VRCZ.Core.Models;
using VRCZ.Core.Services;
using VRCZ.Desktop.ViewModels.Views.Dialogs;
using VRCZ.Desktop.Views.Dialogs.Profile;
using VRCZ.Desktop.Views.ProfileDialog;
using VRCZ.VRChatApi.Generated;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Desktop.ViewModels.Dialogs;

public partial class CreateProfileDialogViewModel : ViewModelBase
{
    [ObservableProperty] private UserControl _currentView;

    [ObservableProperty] private string _username = "";
    [ObservableProperty] private string _password = "";

    [ObservableProperty] private TwoFactorRequired_requiresTwoFactorAuth[] _available2FAMethods = [];

    private readonly VRChatAuthService _vrchatAuthService;
    private readonly VRChatApiClient _vrchatApiClient;
    private readonly ManagedUserProfileService _managedUserProfileService;

    public CreateProfileDialogViewModel(VRChatAuthService vrchatAuthService, VRChatApiClient vrchatApiClient,
        ManagedUserProfileService managedUserProfileService)
    {
        _vrchatAuthService = vrchatAuthService;
        _vrchatApiClient = vrchatApiClient;

        CurrentView = new ProfileDialogLoginView
        {
            DataContext = this
        };
    }

    [RelayCommand]
    private async Task Login()
    {
        try
        {
            var loginResult = await _vrchatAuthService.LoginAsync(Username, Password);

            Available2FAMethods = loginResult.Available2FAMethods ?? [];
            if (loginResult.ResultType == LoginResultType.TwoFactorRequired)
            {
                CurrentView = new DialogOtpView
                {
                    DataContext = this
                };
            }
        }
        catch
        {
            throw;
        }
    }

    [RelayCommand]
    private void ToLoginView()
    {
        CurrentView = new ProfileDialogLoginView
        {
            DataContext = this
        };
    }

    [RelayCommand]
    private void ToOtpView()
    {
        CurrentView = new DialogOtpView
        {
            DataContext = new DialogOtpViewModel(VerifyTotp)
        };
    }

    private async Task VerifyTotp(string code, TwoFactorRequired_requiresTwoFactorAuth method)
    {
        await _vrchatAuthService.VerifyTwoFactorAsync(code, method);

        var user = await _vrchatApiClient.Auth.User.GetAsUserGetResponseAsync();

        await MessageBox.ShowAsync($"[{user?.CurrentUser?.Id}] {user?.CurrentUser?.DisplayName}", "Login Success");

        await _vrchatAuthService.CreateProfileForCurrentAccountAsync(Password);
        // await _managedUserProfileService.LoadProfileAsync();
    }
}
