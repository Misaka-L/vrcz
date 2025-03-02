using System.Text.Json.Serialization;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Models.VRChat.WebSocket.Payload;

public record UserUpdateEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("user")] UserUpdateEventUser User
) : VRChatWebSocketPayloadBase;

public record UserLocationEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("location")]
    string Location,
    [property: JsonPropertyName("instance")]
    string InstanceId,
    [property: JsonPropertyName("user")] User User,
    [property: JsonPropertyName("worldId")]
    string WorldId,
    [property: JsonPropertyName("world")] World World
) : VRChatWebSocketPayloadBase;

public record UserBadgeAssignedEvent(
    [property: JsonPropertyName("badge")] string BadgeId
) : VRChatWebSocketPayloadBase;

public record UserBadgeUnassignedEvent(
    [property: JsonPropertyName("badge")] string BadgeId
) : VRChatWebSocketPayloadBase;

public record ContentRefreshEvent(
    [property: JsonPropertyName("contentType")]
    string ContentType,
    [property: JsonPropertyName("actionType")]
    string ActionType
) : VRChatWebSocketPayloadBase;

public record UserUpdateEventUser(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("username")]
    string Username,
    [property: JsonPropertyName("userIcon")]
    string UserIcon,
    [property: JsonPropertyName("tags")] string[] Tags,
    [property: JsonPropertyName("status")] string Status,
    [property: JsonPropertyName("statusDescription")]
    string StatusDescription,
    [property: JsonPropertyName("profilePicOverride")]
    string ProfilePictureOverride,
    [property: JsonPropertyName("fallbackAvatar")]
    string FallbackAvatarId,
    [property: JsonPropertyName("displayName")]
    string DisplayName,
    [property: JsonPropertyName("currentAvatar")]
    string CurrentAvatarId,
    [property: JsonPropertyName("currentAvatarAssetUrl")]
    string CurrentAvatarAssetUrl,
    [property: JsonPropertyName("currentAvatarImageUrl")]
    string CurrentAvatarImageUrl,
    [property: JsonPropertyName("currentAvatarThumbnailImageUrl")]
    string CurrentAvatarThumbnailImageUrl
) : VRChatWebSocketPayloadBase;
