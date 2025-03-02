using System.Text.Json.Serialization;

namespace VRCZ.Core.Models.VRChat.WebSocket.Payload;

public record InstanceQueueJoinedEvent(
    [property: JsonPropertyName("instanceLocation")]
    string InstanceLocation,
    [property: JsonPropertyName("position")]
    int Position
) : VRChatWebSocketPayloadBase;

public record InstanceQueueReadyEvent(
    [property: JsonPropertyName("instanceLocation")]
    string InstanceLocation,
    [property: JsonPropertyName("expiry")] DateTimeOffset Expiry
) : VRChatWebSocketPayloadBase;
