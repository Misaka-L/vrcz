using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.Input;

namespace VRCZ.App.ViewModels;

public partial class TrayMenuViewModel : ViewModelBase
{
    public IClassicDesktopStyleApplicationLifetime? ApplicationLifetime { get; set; }

    [RelayCommand]
    private void ExitApp()
    {
        ApplicationLifetime?.Shutdown();
    }
}
