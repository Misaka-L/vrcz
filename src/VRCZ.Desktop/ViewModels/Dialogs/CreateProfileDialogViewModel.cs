using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;
using VRCZ.Core.Models;
using VRCZ.Core.Services;
using VRCZ.Desktop.Views;
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

    public CreateProfileDialogViewModel(VRChatAuthService vrchatAuthService, VRChatApiClient vrchatApiClient)
    {
        _vrchatAuthService = vrchatAuthService;
        _vrchatApiClient = vrchatApiClient;

        CurrentView = new ProfileDialogLoginView()
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
                CurrentView = new ProfileDialogOtpView
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
        CurrentView = new ProfileDialogOtpView
        {
            DataContext = this
        };
    }

    [RelayCommand]
    private async Task VerifyTotp(IList<string>? codeDigits)
    {
        if (codeDigits is null)
            return;

        var code = string.Join("", codeDigits);

        await _vrchatAuthService.VerifyTotpAsync(code);

        var user = await _vrchatApiClient.Auth.User.GetAsUserGetResponseAsync();

        await MessageBox.ShowAsync($"[{user?.CurrentUser?.Id}] {user?.CurrentUser?.DisplayName}", "Login Success");

        await _vrchatAuthService.CreateProfileForCurrentAccountAsync(Password);
    }
}
