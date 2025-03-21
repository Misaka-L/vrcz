using CommunityToolkit.Mvvm.Messaging.Messages;
using VRCZ.Core.Models;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.App.ViewMessages.TrackedEntities;

public class LoggedInUserUpdatedMessage(CurrentUser? currentUser) : ValueChangedMessage<CurrentUser?>(currentUser);

public class FriendAddedMessage(LimitedUser limitedUser) : ValueChangedMessage<LimitedUser>(limitedUser);

public class FriendRemovedMessage(LimitedUser limitedUser) : ValueChangedMessage<LimitedUser>(limitedUser);

public class FriendUpdateEvent(LimitedUser user) : ValueChangedMessage<LimitedUser>(user);

public class UserLocationUpdatedMessage(string userId, UserLocation userLocation)
    : ValueChangedMessage<UserLocationUpdatedMessageArgs>(new UserLocationUpdatedMessageArgs(userId, userLocation));

public record UserLocationUpdatedMessageArgs(string UserId, UserLocation UserLocation);
