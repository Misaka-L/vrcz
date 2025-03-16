using CommunityToolkit.Mvvm.Input;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.App.ViewModels.Views.Dialogs;

public partial class DialogOtpViewModel(Func<string, TwoFactorRequired_requiresTwoFactorAuth, Task> verifyTotp) : ViewModelBase
{
    [RelayCommand]
    private async Task VerifyTotp(IList<string>? codeDigits)
    {
        if (codeDigits == null)
        {
            return;
        }

        await verifyTotp(string.Join("", codeDigits), TwoFactorRequired_requiresTwoFactorAuth.Totp);
    }
}
