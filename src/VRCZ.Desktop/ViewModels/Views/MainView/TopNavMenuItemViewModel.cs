using System;
using CommunityToolkit.Mvvm.Input;

namespace VRCZ.Desktop.ViewModels.Views.MainView;

public partial class TopNavMenuItemViewModel(
    string header,
    string? icon,
    Action<NavMenuItemViewModel[]> setMenuItems,
    NavMenuItemViewModel[] items,
    bool isDefault = false)
    : ViewModelBase
{
    public string Header => header;
    public string? Icon => icon;
    public NavMenuItemViewModel[] Items => items;
    public bool IsDefault => isDefault;

    [RelayCommand]
    private void Navigate()
    {
        setMenuItems(Items);
    }
}
