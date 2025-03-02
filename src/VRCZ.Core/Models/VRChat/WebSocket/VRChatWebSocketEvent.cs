using System.Text.Json.Serialization;
using VRCZ.Core.Models.VRChat.WebSocket.Payload;

namespace VRCZ.Core.Models.VRChat.WebSocket;

public record VRChatWebSocketEvent(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("content")]
    string? Content);

public record VRChatWebSocketErrorEvent(
    [property: JsonPropertyName("err")] string ErrorMessage
);

public abstract record VRChatWebSocketPayloadBase;

[JsonSerializable(typeof(VRChatWebSocketEvent))]
[JsonSerializable(typeof(VRChatWebSocketErrorEvent))]
[JsonSerializable(typeof(FriendAddEvent)),
 JsonSerializable(typeof(FriendDeleteEvent)),
 JsonSerializable(typeof(FriendOnlineEvent)),
 JsonSerializable(typeof(FriendActiveEvent)),
 JsonSerializable(typeof(FriendOfflineEvent)),
 JsonSerializable(typeof(FriendUpdateEvent)),
 JsonSerializable(typeof(FriendLocationEvent)),
 JsonSerializable(typeof(GroupJoinedEvent)),
 JsonSerializable(typeof(GroupLeftEvent)),
 JsonSerializable(typeof(GroupMemberUpdateEvent)),
 JsonSerializable(typeof(GroupRoleUpdateEvent)),
 JsonSerializable(typeof(InstanceQueueJoinedEvent)),
 JsonSerializable(typeof(InstanceQueueReadyEvent)),
 JsonSerializable(typeof(WebSocketNotificationV1<WebSocketNotificationV1InviteDetail>)),
 JsonSerializable(typeof(WebSocketNotificationV1<WebSocketNotificationV1InviteResponseDetail>)),
 JsonSerializable(typeof(WebSocketNotificationV1<WebSocketNotificationV1RequestInviteDetail>)),
 JsonSerializable(typeof(WebSocketNotificationV1<WebSocketNotificationV1RequestInviteResponseDetail>)),
 JsonSerializable(typeof(WebSocketNotificationV1<WebSocketNotificationV1VoteToKickDetail>)),
 JsonSerializable(typeof(WebSocketNotificationV1<object>)),
 JsonSerializable(typeof(NotificationEvent)),
 JsonSerializable(typeof(ResponseNotificationEvent)),
 JsonSerializable(typeof(UserUpdateEvent)),
 JsonSerializable(typeof(UserLocationEvent)),
 JsonSerializable(typeof(UserBadgeAssignedEvent)),
 JsonSerializable(typeof(UserBadgeUnassignedEvent)),
 JsonSerializable(typeof(ContentRefreshEvent))
]
[JsonSourceGenerationOptions(RespectRequiredConstructorParameters = true, RespectNullableAnnotations = true)]
public partial class VRChatWebSocketEventContext : JsonSerializerContext;
