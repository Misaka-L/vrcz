using System;
using VRCZ.Desktop.ViewModels;
using VRCZ.Desktop.ViewModels.Pages;

namespace VRCZ.Desktop.Services;

public class NavigationService
{
    private INavigationHost? _navigationHost;

    public event EventHandler<PageViewModelBase> Navigating;
    public event EventHandler<PageViewModelBase> Navigated;

    public void Register(INavigationHost navigationHost)
    {
        _navigationHost = navigationHost;
    }

    public void Navigate(PageViewModelBase pageViewMOdel)
    {
        _navigationHost?.Navigate(pageViewMOdel);
    }
}
