using VRCZ.App.ViewModels.Pages;

namespace VRCZ.App;

public interface INavigationHost
{
    public void Navigate(PageViewModelBase pageViewModel);
}
