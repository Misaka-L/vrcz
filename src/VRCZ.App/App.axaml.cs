using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using HotAvalonia;
using Microsoft.Extensions.DependencyInjection;
using VRCZ.App.ViewModels;

namespace VRCZ.App;

public class App : Application
{
    private readonly IServiceProvider _serviceProvider = null!;

    public App(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public App()
    {
        // Make Previewer happy
    }

    public override void Initialize()
    {
        this.EnableHotReload();
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var trayMenuViewModel = _serviceProvider.GetRequiredService<TrayMenuViewModel>();
            trayMenuViewModel.ApplicationLifetime = desktop;

            DataContext = trayMenuViewModel;

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
