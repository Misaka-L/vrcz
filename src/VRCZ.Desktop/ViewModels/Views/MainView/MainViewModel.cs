using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VRCZ.Desktop.Services;
using VRCZ.Desktop.ViewModels.Pages;

namespace VRCZ.Desktop.ViewModels.Views.MainView;

public partial class MainViewModel : ViewModelBase, INavigationHost
{
    [ObservableProperty] private PageViewModelBase? _currentPage;

    public MainNavMenuViewModel NavMenu { get; }

    private readonly NavigationService _navigationService;
    private readonly IServiceProvider _serviceProvider;

    public MainViewModel(NavigationService navigationService, IServiceProvider serviceProvider,
        MainNavMenuViewModel mainNavMenuViewModel)
    {
        _navigationService = navigationService;
        _serviceProvider = serviceProvider;
        NavMenu = mainNavMenuViewModel;

        _navigationService.Register(this);

        NavMenu.Init();
    }

    public void Navigate(PageViewModelBase pageViewModel)
    {
        CurrentPage = pageViewModel;
    }

    [RelayCommand]
    private void GoHome()
    {
        _navigationService.Navigate(new HomeViewModel());
    }
}
