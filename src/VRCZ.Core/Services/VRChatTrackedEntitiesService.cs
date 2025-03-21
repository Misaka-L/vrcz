using System.Collections.Concurrent;
using VRCZ.Core.Exceptions;
using VRCZ.Core.Mappers;
using VRCZ.Core.Models;
using VRCZ.Core.Models.VRChat.TrackedEntities;
using VRCZ.Core.Models.VRChat.WebSocket;
using VRCZ.VRChatApi.Generated;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Services;

public class VRChatTrackedEntitiesService(VRChatApiClient vrchatApiClient)
{
    private CurrentUser? _loggedInUser;

    private readonly ConcurrentDictionary<string, TrackedVRChatUser> _friends = new();
    private readonly ConcurrentDictionary<string, UserLocation> _userLocations = new();

    public event EventHandler<CurrentUser?>? LoggedInUserUpdated;

    public event EventHandler<LimitedUser>? FriendAdded;
    public event EventHandler<LimitedUser>? FriendRemoved;
    public event EventHandler<LimitedUser>? FriendUpdated;

    public event EventHandler<UserLocationUpdatedEventArgs>? UserLocationUpdated;

    public CurrentUser? GetLoggedInUser()
    {
        return _loggedInUser;
    }

    #region Cache AddOrUpdate

    internal void SetLoggedInUser(CurrentUser user)
    {
        _loggedInUser = user;

        LoggedInUserUpdated?.Invoke(this, user);
    }

    internal void AddOrUpdateFriend(TrackedVRChatUser user)
    {
        var userExist = _friends.ContainsKey(user.Id);

        _friends.AddOrUpdate(user.Id, user, (_, _) => user);

        if (_userLocations.TryGetValue(user.Id, out var userLocation) &&
            userLocation.ToLocationString() != user.Location)
        {
            AddOrUpdateUserLocation(user.Id, userLocation);
        }

        if (userExist)
        {
            FriendUpdated?.Invoke(this, TrackedVRChatEntitiesMapper.ToLimitedUser(user));
            return;
        }

        FriendAdded?.Invoke(this, TrackedVRChatEntitiesMapper.ToLimitedUser(user));
    }

    internal void AddOrUpdateFriend(LimitedUser user)
    {
        if (user.Id is null)
            throw new ArgumentException("User ID cannot be null", nameof(user));

        TrackedVRChatUser trackedUser;
        if (_friends.GetValueOrDefault(user.Id) is { } friend)
        {
            trackedUser = TrackedVRChatEntitiesMapper.ApplyUpdateToTrackedUser(friend, user);
        }
        else
        {
            trackedUser = TrackedVRChatEntitiesMapper.ToTrackedUser(user);
        }

        AddOrUpdateFriend(trackedUser);
    }

    internal void AddOrUpdateFriend(User user)
    {
        if (user.Id is null)
            throw new ArgumentException("User ID cannot be null", nameof(user));

        TrackedVRChatUser trackedUser;
        if (_friends.GetValueOrDefault(user.Id) is { } friend)
        {
            trackedUser = TrackedVRChatEntitiesMapper.ApplyUpdateToTrackedUser(friend, user);
        }
        else
        {
            trackedUser = TrackedVRChatEntitiesMapper.ToTrackedUser(user);
        }

        AddOrUpdateFriend(trackedUser);
    }

    internal void AddOrUpdateFriend(VRChatWebSocketFriendUser user)
    {
        if (user.Id is null)
            throw new ArgumentException("User ID cannot be null", nameof(user));

        TrackedVRChatUser trackedUser;
        if (_friends.GetValueOrDefault(user.Id) is { } friend)
        {
            trackedUser = TrackedVRChatEntitiesMapper.ApplyUpdateToTrackedUser(friend, user);
        }
        else
        {
            trackedUser = TrackedVRChatEntitiesMapper.ToTrackedUser(user);
        }

        AddOrUpdateFriend(trackedUser);
    }

    internal void RemoveFriend(string userId)
    {
        if (!_friends.TryRemove(userId, out var removedFriend))
            return;

        var user = TrackedVRChatEntitiesMapper.ToLimitedUser(removedFriend);
        FriendRemoved?.Invoke(this, user);
    }

    internal void AddOrUpdateUserLocation(string userId, UserLocation userLocation)
    {
        var locationString = userLocation.ToLocationString();

        if (_friends.TryGetValue(userId, out var trackedUser) && trackedUser.Location != locationString)
        {
            trackedUser.Location = locationString;
            AddOrUpdateFriend(trackedUser);
        }

        _userLocations.AddOrUpdate(userId, userLocation, (_, _) => userLocation);
        UserLocationUpdated?.Invoke(this, new UserLocationUpdatedEventArgs(userId, userLocation));
    }

    #endregion

    public async ValueTask<User> GetUserAsync(string userId)
    {
        var user = await vrchatApiClient.Users[userId].GetAsync();

        if (user is null)
            throw new UnexpectedApiBehaviourException("User response body is null");

        if (_loggedInUser?.Id == userId)
        {
            _loggedInUser = VRChatUserMapper.UserToCurrentUser(user);
        }

        if (_loggedInUser?.Friends?.Contains(userId) ?? false)
        {
            AddOrUpdateFriend(user);
        }

        return user;
    }

    public LimitedUser[] GetFriends()
    {
        return _friends.Values.Select(TrackedVRChatEntitiesMapper.ToLimitedUser).ToArray();
    }

    public async ValueTask<LimitedUser[]> GetFriendsAsync()
    {
        var onlineOrActiveFriends = await GetAllFriendsInternalAsync(false);
        var offlineFriends = await GetAllFriendsInternalAsync(true);

        var friends = onlineOrActiveFriends.Concat(offlineFriends).ToArray();

        foreach (var friend in friends)
        {
            AddOrUpdateFriend(friend);
        }

        return friends;
    }

    private async ValueTask<LimitedUser[]> GetAllFriendsInternalAsync(bool offline)
    {
        List<LimitedUser> friends = [];

        const int pageSize = 100;
        for (var offset = 0;; offset += pageSize)
        {
            var response = await vrchatApiClient.Auth.User.Friends.GetAsync(config =>
            {
                config.QueryParameters.Offline = offline;
                config.QueryParameters.N = pageSize;
                config.QueryParameters.Offset = offset;
            });

            if (response is null)
                throw new UnexpectedApiBehaviourException("Friends response body is null");

            friends.AddRange(response);

            if (response.Count < pageSize)
                break;
        }

        return friends.ToArray();
    }
}

public class UserLocationUpdatedEventArgs(string userId, UserLocation userLocation) : EventArgs
{
    public string UserId { get; } = userId;
    public UserLocation UserLocation { get; } = userLocation;
}
