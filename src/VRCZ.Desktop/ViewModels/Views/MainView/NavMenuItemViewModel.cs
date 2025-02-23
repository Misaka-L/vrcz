using System;
using CommunityToolkit.Mvvm.Input;

namespace VRCZ.Desktop.ViewModels.Views.MainView;

public partial class NavMenuItemViewModel(
    string header,
    string? icon = null,
    Action<Type>? navigateAction = null,
    Type? viewModelType = null,
    bool isSeparator = false,
    bool isDefault = false) : ViewModelBase
{
    public string Header => header;
    public string? Icon => icon;
    public bool IsSeparator => isSeparator;
    public bool IsDefault => isDefault;

    [RelayCommand]
    public void Navigate()
    {
        if (viewModelType is null)
            return;

        navigateAction?.Invoke(viewModelType);
    }
}
