using Riok.Mapperly.Abstractions;
using VRCZ.Core.Models.VRChat.TrackedEntities;
using VRCZ.Core.Models.VRChat.WebSocket;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.None, AllowNullPropertyAssignment = true)]
public static partial class TrackedVRChatEntitiesMapper
{
    public static partial TrackedVRChatUser ToTrackedUser(LimitedUser limitedUser);

    public static partial LimitedUser ToLimitedUser(TrackedVRChatUser trackedUser);

    public static partial TrackedVRChatUser ToTrackedUser(User limitedUser);

    public static partial User ToUser(TrackedVRChatUser trackedUser);

    public static partial TrackedVRChatUser ToTrackedUser(VRChatWebSocketFriendUser webSocketUser);

    public static partial TrackedVRChatUser ApplyUpdateToTrackedUser(TrackedVRChatUser trackedUser, User userUpdate);

    public static partial TrackedVRChatUser ApplyUpdateToTrackedUser(TrackedVRChatUser trackedUser, LimitedUser userUpdate);

    public static partial TrackedVRChatUser ApplyUpdateToTrackedUser(TrackedVRChatUser trackedUser, VRChatWebSocketFriendUser userUpdate);
}
