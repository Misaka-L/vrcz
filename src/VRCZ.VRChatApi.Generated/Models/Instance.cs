// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace VRCZ.VRChatApi.Generated.Models
{
    /// <summary>
    /// * `hidden` field is only present if InstanceType is `hidden` aka &quot;Friends+&quot;, and is instance creator.* `friends` field is only present if InstanceType is `friends` aka &quot;Friends&quot;, and is instance creator.* `private` field is only present if InstanceType is `private` aka &quot;Invite&quot; or &quot;Invite+&quot;, and is instance creator.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Instance : IAdditionalDataHolder, IParsable
    {
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ageGate property</summary>
        public bool? AgeGate { get; set; }
        /// <summary>The canRequestInvite property</summary>
        public bool? CanRequestInvite { get; set; }
        /// <summary>The capacity property</summary>
        public int? Capacity { get; set; }
        /// <summary>Always returns &quot;unknown&quot;.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientNumber { get; set; }
#nullable restore
#else
        public string ClientNumber { get; set; }
#endif
        /// <summary>The closedAt property</summary>
        public DateTimeOffset? ClosedAt { get; set; }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Friends { get; set; }
#nullable restore
#else
        public string Friends { get; set; }
#endif
        /// <summary>The full property</summary>
        public bool? Full { get; set; }
        /// <summary>The gameServerVersion property</summary>
        public int? GameServerVersion { get; set; }
        /// <summary>Group access type when the instance type is &quot;group&quot;</summary>
        public global::VRCZ.VRChatApi.Generated.Models.GroupAccessType? GroupAccessType { get; set; }
        /// <summary>The hardClose property</summary>
        public bool? HardClose { get; set; }
        /// <summary>The hasCapacityForYou property</summary>
        public bool? HasCapacityForYou { get; set; }
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hidden { get; set; }
#nullable restore
#else
        public string Hidden { get; set; }
#endif
        /// <summary>InstanceID can be &quot;offline&quot; on User profiles if you are not friends with that user and &quot;private&quot; if you are friends and user is in private instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The instanceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceId { get; set; }
#nullable restore
#else
        public string InstanceId { get; set; }
#endif
        /// <summary>The instancePersistenceEnabled property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstancePersistenceEnabled { get; set; }
#nullable restore
#else
        public string InstancePersistenceEnabled { get; set; }
#endif
        /// <summary>InstanceID can be &quot;offline&quot; on User profiles if you are not friends with that user and &quot;private&quot; if you are friends and user is in private instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The nonce property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nonce { get; set; }
#nullable restore
#else
        public string Nonce { get; set; }
#endif
        /// <summary>The n_users property</summary>
        public int? NUsers { get; set; }
        /// <summary>A groupId if the instance type is &quot;group&quot;, null if instance type is public, or a userId otherwise</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId { get; set; }
#nullable restore
#else
        public string OwnerId { get; set; }
#endif
        /// <summary>The permanent property</summary>
        public bool? Permanent { get; set; }
        /// <summary>API/Photon region.</summary>
        public global::VRCZ.VRChatApi.Generated.Models.Region? PhotonRegion { get; set; }
        /// <summary>The platforms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.InstancePlatforms? Platforms { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.InstancePlatforms Platforms { get; set; }
#endif
        /// <summary>The playerPersistenceEnabled property</summary>
        public bool? PlayerPersistenceEnabled { get; set; }
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Private { get; set; }
#nullable restore
#else
        public string Private { get; set; }
#endif
        /// <summary>The queueEnabled property</summary>
        public bool? QueueEnabled { get; set; }
        /// <summary>The queueSize property</summary>
        public int? QueueSize { get; set; }
        /// <summary>The recommendedCapacity property</summary>
        public int? RecommendedCapacity { get; set; }
        /// <summary>Instance region</summary>
        public global::VRCZ.VRChatApi.Generated.Models.InstanceRegion? Region { get; set; }
        /// <summary>The roleRestricted property</summary>
        public bool? RoleRestricted { get; set; }
        /// <summary>The secureName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecureName { get; set; }
#nullable restore
#else
        public string SecureName { get; set; }
#endif
        /// <summary>The shortName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortName { get; set; }
#nullable restore
#else
        public string ShortName { get; set; }
#endif
        /// <summary>The strict property</summary>
        public bool? Strict { get; set; }
        /// <summary>The tags array on Instances usually contain the language tags of the people in the instance. </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.InstanceType? Type { get; set; }
        /// <summary>The userCount property</summary>
        public int? UserCount { get; set; }
        /// <summary>The users field is present on instances created by the requesting user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::VRCZ.VRChatApi.Generated.Models.LimitedUser>? Users { get; set; }
#nullable restore
#else
        public List<global::VRCZ.VRChatApi.Generated.Models.LimitedUser> Users { get; set; }
#endif
        /// <summary>The world property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.World? World { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.World World { get; set; }
#endif
        /// <summary>WorldID be &quot;offline&quot; on User profiles if you are not friends with that user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorldId { get; set; }
#nullable restore
#else
        public string WorldId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.Instance"/> and sets the default values.
        /// </summary>
        public Instance()
        {
            AdditionalData = new Dictionary<string, object>();
            GroupAccessType = global::VRCZ.VRChatApi.Generated.Models.GroupAccessType.Members;
            PhotonRegion = global::VRCZ.VRChatApi.Generated.Models.Region.Us;
            Region = global::VRCZ.VRChatApi.Generated.Models.InstanceRegion.Us;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.Instance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.Instance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.Instance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "ageGate", n => { AgeGate = n.GetBoolValue(); } },
                { "canRequestInvite", n => { CanRequestInvite = n.GetBoolValue(); } },
                { "capacity", n => { Capacity = n.GetIntValue(); } },
                { "clientNumber", n => { ClientNumber = n.GetStringValue(); } },
                { "closedAt", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "friends", n => { Friends = n.GetStringValue(); } },
                { "full", n => { Full = n.GetBoolValue(); } },
                { "gameServerVersion", n => { GameServerVersion = n.GetIntValue(); } },
                { "groupAccessType", n => { GroupAccessType = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.GroupAccessType>(); } },
                { "hardClose", n => { HardClose = n.GetBoolValue(); } },
                { "hasCapacityForYou", n => { HasCapacityForYou = n.GetBoolValue(); } },
                { "hidden", n => { Hidden = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "instanceId", n => { InstanceId = n.GetStringValue(); } },
                { "instancePersistenceEnabled", n => { InstancePersistenceEnabled = n.GetStringValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "n_users", n => { NUsers = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "nonce", n => { Nonce = n.GetStringValue(); } },
                { "ownerId", n => { OwnerId = n.GetStringValue(); } },
                { "permanent", n => { Permanent = n.GetBoolValue(); } },
                { "photonRegion", n => { PhotonRegion = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.Region>(); } },
                { "platforms", n => { Platforms = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.InstancePlatforms>(global::VRCZ.VRChatApi.Generated.Models.InstancePlatforms.CreateFromDiscriminatorValue); } },
                { "playerPersistenceEnabled", n => { PlayerPersistenceEnabled = n.GetBoolValue(); } },
                { "private", n => { Private = n.GetStringValue(); } },
                { "queueEnabled", n => { QueueEnabled = n.GetBoolValue(); } },
                { "queueSize", n => { QueueSize = n.GetIntValue(); } },
                { "recommendedCapacity", n => { RecommendedCapacity = n.GetIntValue(); } },
                { "region", n => { Region = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.InstanceRegion>(); } },
                { "roleRestricted", n => { RoleRestricted = n.GetBoolValue(); } },
                { "secureName", n => { SecureName = n.GetStringValue(); } },
                { "shortName", n => { ShortName = n.GetStringValue(); } },
                { "strict", n => { Strict = n.GetBoolValue(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "type", n => { Type = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.InstanceType>(); } },
                { "userCount", n => { UserCount = n.GetIntValue(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.LimitedUser>(global::VRCZ.VRChatApi.Generated.Models.LimitedUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "world", n => { World = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.World>(global::VRCZ.VRChatApi.Generated.Models.World.CreateFromDiscriminatorValue); } },
                { "worldId", n => { WorldId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteBoolValue("ageGate", AgeGate);
            writer.WriteBoolValue("canRequestInvite", CanRequestInvite);
            writer.WriteIntValue("capacity", Capacity);
            writer.WriteStringValue("clientNumber", ClientNumber);
            writer.WriteDateTimeOffsetValue("closedAt", ClosedAt);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("friends", Friends);
            writer.WriteBoolValue("full", Full);
            writer.WriteIntValue("gameServerVersion", GameServerVersion);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.GroupAccessType>("groupAccessType", GroupAccessType);
            writer.WriteBoolValue("hardClose", HardClose);
            writer.WriteBoolValue("hasCapacityForYou", HasCapacityForYou);
            writer.WriteStringValue("hidden", Hidden);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("instanceId", InstanceId);
            writer.WriteStringValue("instancePersistenceEnabled", InstancePersistenceEnabled);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("nonce", Nonce);
            writer.WriteIntValue("n_users", NUsers);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteBoolValue("permanent", Permanent);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.Region>("photonRegion", PhotonRegion);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.InstancePlatforms>("platforms", Platforms);
            writer.WriteBoolValue("playerPersistenceEnabled", PlayerPersistenceEnabled);
            writer.WriteStringValue("private", Private);
            writer.WriteBoolValue("queueEnabled", QueueEnabled);
            writer.WriteIntValue("queueSize", QueueSize);
            writer.WriteIntValue("recommendedCapacity", RecommendedCapacity);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.InstanceRegion>("region", Region);
            writer.WriteBoolValue("roleRestricted", RoleRestricted);
            writer.WriteStringValue("secureName", SecureName);
            writer.WriteStringValue("shortName", ShortName);
            writer.WriteBoolValue("strict", Strict);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.InstanceType>("type", Type);
            writer.WriteIntValue("userCount", UserCount);
            writer.WriteCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.LimitedUser>("users", Users);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.World>("world", World);
            writer.WriteStringValue("worldId", WorldId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
