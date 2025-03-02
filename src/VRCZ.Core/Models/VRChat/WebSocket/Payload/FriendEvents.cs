using System.Text.Json.Serialization;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Models.VRChat.WebSocket.Payload;

public record FriendAddEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("user")] User User
) : VRChatWebSocketPayloadBase;

public record FriendDeleteEvent(
    [property: JsonPropertyName("userId")] string UserId
) : VRChatWebSocketPayloadBase;

public record FriendOnlineEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("platform")]
    string Platform,
    [property: JsonPropertyName("location")]
    string Location,
    [property: JsonPropertyName("canRequestInvite")]
    bool CanRequestInvite,
    [property: JsonPropertyName("user")] User User
) : VRChatWebSocketPayloadBase;

public record FriendActiveEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("platform")]
    string Platform,
    [property: JsonPropertyName("user")] User User
) : VRChatWebSocketPayloadBase;

public record FriendOfflineEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("location")]
    string Location
) : VRChatWebSocketPayloadBase;

public record FriendUpdateEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("user")] User User
) : VRChatWebSocketPayloadBase;

public record FriendLocationEvent(
    [property: JsonPropertyName("userId")] string UserId,
    [property: JsonPropertyName("location")]
    string Location,
    [property: JsonPropertyName("travelingToLocation")]
    string TravelingToLocation,
    [property: JsonPropertyName("canRequestInvite")]
    bool CanRequestInvite,
    [property: JsonPropertyName("user")] User User
) : VRChatWebSocketPayloadBase;
