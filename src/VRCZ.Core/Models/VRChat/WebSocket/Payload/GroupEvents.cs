using System.Text.Json.Serialization;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Models.VRChat.WebSocket.Payload;

public record GroupJoinedEvent(
    [property: JsonPropertyName("groupId")]
    string GroupId
) : VRChatWebSocketPayloadBase;

public record GroupLeftEvent(
    [property: JsonPropertyName("groupId")]
    string GroupId
) : VRChatWebSocketPayloadBase;

public record GroupMemberUpdateEvent(
    [property: JsonPropertyName("member")] GroupLimitedMember[] Members
) : VRChatWebSocketPayloadBase;

public record GroupRoleUpdateEvent(
    [property: JsonPropertyName("role")] GroupRole[] Roles
) : VRChatWebSocketPayloadBase;
