using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using VRCZ.Desktop.ViewModels;

namespace VRCZ.Desktop;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var trayMenuViewModel = Program.ServiceProvider.GetRequiredService<TrayMenuViewModel>();
            trayMenuViewModel.ApplicationLifetime = desktop;

            DataContext = trayMenuViewModel;

            var mainWindow = Program.ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
