using VRCZ.App.ViewModels.Pages;

namespace VRCZ.App.Services;

public class NavigationService
{
    private INavigationHost? _navigationHost;

    public void Register(INavigationHost navigationHost)
    {
        _navigationHost = navigationHost;
    }

    public void Navigate(PageViewModelBase pageViewMOdel)
    {
        _navigationHost?.Navigate(pageViewMOdel);
    }
}
