using System.Text.Json.Serialization;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Models.VRChat.WebSocket.Payload;

public record NotificationEvent(
    Notification Notification
) : VRChatWebSocketPayloadBase;

public record ResponseNotificationEvent(
    [property: JsonPropertyName("notificationId")]
    string NotificationId,
    [property: JsonPropertyName("receiverId")]
    string ReceiverId,
    [property: JsonPropertyName("responseId")]
    string ResponseId
) : VRChatWebSocketPayloadBase;

public record SeeNotificationEvent(
    string NotificationId
) : VRChatWebSocketPayloadBase;

public record HideNotificationEvent(
    string NotificationId
) : VRChatWebSocketPayloadBase;

public record ClearNotificationEvent : VRChatWebSocketPayloadBase;

public record WebSocketNotificationV1<T>(
    [property: JsonPropertyName("created_at")]
    DateTimeOffset CreatedAt,
    [property: JsonPropertyName("details")]
    T Details,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("receiverUserId")]
    string? ReceiverUserId,
    [property: JsonPropertyName("senderUserId")]
    string SenderUserId,
    [property: JsonPropertyName("type")] string Type
) : VRChatWebSocketPayloadBase;

public record WebSocketNotificationV1InviteDetail(
    [property: JsonPropertyName("worldId")]
    string WorldId,
    [property: JsonPropertyName("worldName")]
    string WorldName,
    [property: JsonPropertyName("inviteMessage")]
    string InviteMessage
);

public record WebSocketNotificationV1InviteResponseDetail(
    [property: JsonPropertyName("inResponseTo")] string ResponseToNotificationId,
    [property: JsonPropertyName("responseMessage")] string ResponseMessage
);

public record WebSocketNotificationV1RequestInviteDetail(
    [property: JsonPropertyName("requestMessage")]
    string RequestMessage
);

public record WebSocketNotificationV1RequestInviteResponseDetail(
    [property: JsonPropertyName("inResponseTo")] string ResponseToNotificationId,
    [property: JsonPropertyName("requestMessage")] string RequestMessage
);

public record WebSocketNotificationV1VoteToKickDetail(
    [property: JsonPropertyName("initiatorUserId")] string InitiatorUserId,
    [property: JsonPropertyName("userToKickId")] string TargetUserId
);
