using VRCZ.Desktop.ViewModels;
using VRCZ.Desktop.ViewModels.Pages;

namespace VRCZ.Desktop;

public interface INavigationHost
{
    public void Navigate(PageViewModelBase pageViewModel);
}
