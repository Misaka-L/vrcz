namespace VRCZ.App.ViewModels.Pages;

public abstract class PageViewModelBase : ViewModelBase
{
    public virtual bool CanNavigate => true;
    public virtual bool FullPage => false;
}
