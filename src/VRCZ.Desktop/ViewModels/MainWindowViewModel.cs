using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using VRCZ.Core.Services;
using VRCZ.Desktop.ViewMessages;
using VRCZ.Desktop.ViewModels.Views;
using VRCZ.Desktop.ViewModels.Views.MainView;

namespace VRCZ.Desktop.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ViewModelBase _currentView;

    public MainWindowViewModel(UserProfileService userProfileService, IServiceProvider serviceProvider)
    {
        CurrentView = userProfileService.IsProfileLoaded
            ? serviceProvider.GetRequiredService<MainViewModel>()
            : serviceProvider.GetRequiredService<ProfileSelectionViewModel>();

        userProfileService.ProfileChanged += (_, _) =>
        {
            if (userProfileService.IsProfileLoaded || CurrentView is ProfileSelectionViewModel)
            {
                return;
            }

            CurrentView = serviceProvider.GetRequiredService<ProfileSelectionViewModel>();
        };

        WeakReferenceMessenger.Default.Register<ShowMainViewMessage>(this, (_, _) =>
        {
            if (!userProfileService.IsProfileLoaded)
                return;

            CurrentView = serviceProvider.GetRequiredService<MainViewModel>();
        });
    }
}
