using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using VRCZ.Core.Services;
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
            CurrentView = userProfileService.IsProfileLoaded
                ? serviceProvider.GetRequiredService<MainViewModel>()
                : serviceProvider.GetRequiredService<ProfileSelectionViewModel>();
        };
    }
}
