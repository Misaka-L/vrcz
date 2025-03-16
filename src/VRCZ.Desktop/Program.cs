using Avalonia;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Lemon.Hosting.AvaloniauiDesktop;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using VRCZ.Core.Extensions;
using VRCZ.Desktop.Pages;
using VRCZ.Desktop.Services;
using VRCZ.Desktop.ViewModels;
using VRCZ.Desktop.ViewModels.Dialogs;
using VRCZ.Desktop.ViewModels.Pages;
using VRCZ.Desktop.ViewModels.Views;
using VRCZ.Desktop.ViewModels.Views.MainView;

namespace VRCZ.Desktop;

internal sealed class Program
{
#pragma warning disable CS8618
    public static IServiceProvider ServiceProvider { get; private set; }
#pragma warning restore CS8618

    [STAThread]
    [SupportedOSPlatform("windows")]
    [SupportedOSPlatform("linux")]
    [SupportedOSPlatform("macos")]
    [RequiresDynamicCode("Calls Microsoft.Extensions.Hosting.Host.CreateApplicationBuilder()")]
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .Enrich.FromLogContext()
            .WriteTo.Console(theme: AnsiConsoleTheme.Literate, applyThemeToRedirectedOutput: true)
            .WriteTo.Debug()
            .CreateLogger();

        var hostBuilder = Host.CreateEmptyApplicationBuilder(new HostApplicationBuilderSettings
        {
            Args = args,
            ApplicationName = "VRCZ.Desktop",
            ContentRootPath = Environment.CurrentDirectory
        });

        hostBuilder.Configuration
            .AddCommandLine(args)
            .AddInMemoryCollection();

        hostBuilder.Services.AddSerilog();

        hostBuilder.Services.AddVRCZCore();

        RunApp(hostBuilder, args);
    }

    private static AppBuilder ConfigAvaloniaAppBuilder(AppBuilder appBuilder)
    {
        return appBuilder
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
    }

    [SupportedOSPlatform("windows")]
    [SupportedOSPlatform("linux")]
    [SupportedOSPlatform("macos")]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private static void RunApp(HostApplicationBuilder hostBuilder, string[] args)
    {
        ViewLocator.Register<HomeViewModel, HomePage>();
        hostBuilder.Services.AddSingleton<NavigationService>();

        hostBuilder.Services.AddTransient<RemoteImageLoadService>();
        hostBuilder.Services.AddHttpClient<RemoteImageLoadService>(client =>
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("VRCZ.Desktop", "snapshot"))
            )
            .ConfigurePrimaryHttpMessageHandler(() => new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(2),
            });

        hostBuilder.Services.AddSingleton<TrayMenuViewModel>();
        hostBuilder.Services.AddTransient<MainViewModel>();
        hostBuilder.Services.AddTransient<ProfileSelectionViewModel>();
        hostBuilder.Services.AddTransient<CreateProfileDialogViewModel>();
        hostBuilder.Services.AddSingleton<MainWindowViewModel>();

        hostBuilder.Services.AddTransient<MainNavMenuViewModel>();
        hostBuilder.Services.AddTransient<HomeViewModel>();

        hostBuilder.Services.AddAvaloniauiDesktopApplication<App>(ConfigAvaloniaAppBuilder);
        hostBuilder.Services.AddMainWindow<MainWindow, MainWindowViewModel>();
        hostBuilder.Services.AddApplicationLifetime<MainWindow>(_ => new ClassicDesktopStyleApplicationLifetime
        {
            ShutdownMode = ShutdownMode.OnExplicitShutdown,
            Args = args
        });

        // build host
        var appHost = hostBuilder.Build();
        ServiceProvider = appHost.Services.GetRequiredService<IServiceProvider>();

        // run app
        appHost.RunAvaloniauiApplication(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}
