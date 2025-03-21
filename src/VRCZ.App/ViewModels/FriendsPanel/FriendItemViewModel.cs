using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using VRCZ.App.ViewMessages.TrackedEntities;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.App.ViewModels.FriendsPanel;

public partial class FriendItemViewModel : ViewModelBase
{
    [ObservableProperty] private LimitedUser _user;
    [ObservableProperty] private string? _location;

    public FriendItemViewModel(WeakReferenceMessenger weakReferenceMessenger, LimitedUser limitedUser)
    {
        _user = limitedUser;
        _location = limitedUser.Location;

        weakReferenceMessenger.Register<FriendItemViewModel, FriendUpdateEvent>(this, (recipient, message) =>
        {
            if (recipient.User.Id != message.Value.Id)
                return;

            recipient.User = message.Value;
        });

        weakReferenceMessenger.Register<FriendItemViewModel, UserLocationUpdatedMessage>(this, (recipient, message) =>
        {
            if (recipient.User.Id != message.Value.UserId)
                return;

            recipient.Location = message.Value.UserLocation.ToString();
        });
    }
}
