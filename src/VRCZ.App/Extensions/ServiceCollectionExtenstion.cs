﻿using System.Net.Http.Headers;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using VRCZ.App.Services;
using VRCZ.App.ViewModels;
using VRCZ.App.ViewModels.Dialogs;
using VRCZ.App.ViewModels.FriendsPanel;
using VRCZ.App.ViewModels.Pages;
using VRCZ.App.ViewModels.Views;
using VRCZ.App.ViewModels.Views.MainView;

namespace VRCZ.App.Extenstions;

public static class ServiceCollectionExtenstion
{
    public static IServiceCollection AddVRCZApp(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<NavigationService>();

        serviceCollection.AddTransient<RemoteImageLoadService>();
        serviceCollection.AddHttpClient<RemoteImageLoadService>(client =>
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("VRCZ.App", "snapshot"))
            )
            .ConfigurePrimaryHttpMessageHandler(() => new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(2),
            });

        serviceCollection.AddSingleton<TrayMenuViewModel>();
        serviceCollection.AddTransient<MainViewModel>();
        serviceCollection.AddTransient<ProfileSelectionViewModel>();
        serviceCollection.AddTransient<CreateProfileDialogViewModel>();
        serviceCollection.AddTransient<FriendsPanelViewModel>();
        serviceCollection.AddSingleton<MainWindowViewModel>();

        serviceCollection.AddTransient<MainNavMenuViewModel>();
        serviceCollection.AddTransient<HomeViewModel>();

        serviceCollection.AddSingleton<WeakReferenceMessenger>();

        serviceCollection.AddHostedService<TrackedEntitiesMessengerService>();

        return serviceCollection;
    }
}
