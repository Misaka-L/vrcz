﻿using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using CommunityToolkit.Mvvm.ComponentModel;
using VRCZ.Desktop.ViewModels;
using VRCZ.Desktop.ViewModels.Pages;

namespace VRCZ.Desktop;

public class ViewLocator : IDataTemplate
{
    public static IReadOnlyDictionary<Type, Func<Control>> Views => _views.AsReadOnly();
    private static readonly Dictionary<Type, Func<Control>> _views = new();

    public static void Register<TViewModel, TView>() where TView : Control, new() where TViewModel : PageViewModelBase
    {
        _views.Add(typeof(TViewModel), () => new TView());
    }

    public static void Register<TViewModel, TView>(Func<TView> factory)
        where TView : Control where TViewModel : PageViewModelBase
    {
        _views.Add(typeof(TViewModel), factory);
    }

    public Control Build(object? param)
    {
        if (param is null)
        {
            return new TextBlock { Text = "Not Found: param is null" };
        }

        var type = param.GetType();

        if (!Views.TryGetValue(type, out var factory))
        {
            return new TextBlock { Text = "Not Found: " + type };
        }

        return factory();
    }

    public bool Match(object? data)
    {
        return data is ObservableObject;
    }
}
