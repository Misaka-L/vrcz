﻿using System;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using VRCZ.Core.Models;
using VRCZ.Core.Services;
using VRCZ.Desktop.Services;
using VRCZ.Desktop.ViewMessages;

namespace VRCZ.Desktop.ViewModels;

public partial class UserProfileItemViewModel(
    UserProfile userProfile,
    RemoteImageLoadService remoteImageLoadService,
    ManagedUserProfileService managedUserProfileService) : ViewModelBase
{
    public UserProfile UserProfile => userProfile;
    public Task<Bitmap?> ProfileImage => remoteImageLoadService.LoadImageAsync(UserProfile.AvatarUrl);

    public event EventHandler<Exception>? ErrorOccured;

    [RelayCommand]
    private async Task LoadProfile()
    {
        try
        {
            await managedUserProfileService.LoadProfileAsync(UserProfile.Id);

            WeakReferenceMessenger.Default.Send<ShowMainViewMessage>();
        }
        catch (Exception ex)
        {
            ErrorOccured?.Invoke(this, ex);
        }
    }
}
