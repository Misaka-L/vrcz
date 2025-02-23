// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace VRCZ.VRChatApi.Generated.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Notification : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>**NOTICE:** This is not a JSON object when received from the REST API, but it is when received from the Websocket API. When received from the REST API, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Details { get; set; }
#nullable restore
#else
        public string Details { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReceiverUserId { get; set; }
#nullable restore
#else
        public string ReceiverUserId { get; set; }
#endif
        /// <summary>Not included in notification objects received from the Websocket API</summary>
        public bool? Seen { get; set; }
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderUserId { get; set; }
#nullable restore
#else
        public string SenderUserId { get; set; }
#endif
        /// <summary>-| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429).</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderUsername { get; set; }
#nullable restore
#else
        public string SenderUsername { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.NotificationType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.Notification"/> and sets the default values.
        /// </summary>
        public Notification()
        {
            AdditionalData = new Dictionary<string, object>();
            Details = "{}";
            Type = global::VRCZ.VRChatApi.Generated.Models.NotificationType.FriendRequest;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.Notification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.Notification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.Notification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "details", n => { Details = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "receiverUserId", n => { ReceiverUserId = n.GetStringValue(); } },
                { "seen", n => { Seen = n.GetBoolValue(); } },
                { "senderUserId", n => { SenderUserId = n.GetStringValue(); } },
                { "senderUsername", n => { SenderUsername = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.NotificationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("details", Details);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("receiverUserId", ReceiverUserId);
            writer.WriteBoolValue("seen", Seen);
            writer.WriteStringValue("senderUserId", SenderUserId);
            writer.WriteStringValue("senderUsername", SenderUsername);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.NotificationType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
