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
    public partial class Feedback : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommenterId { get; set; }
#nullable restore
#else
        public string CommenterId { get; set; }
#endif
        /// <summary>The commenterName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommenterName { get; set; }
#nullable restore
#else
        public string CommenterName { get; set; }
#endif
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentAuthorId { get; set; }
#nullable restore
#else
        public string ContentAuthorId { get; set; }
#endif
        /// <summary>The contentAuthorName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentAuthorName { get; set; }
#nullable restore
#else
        public string ContentAuthorName { get; set; }
#endif
        /// <summary>The contentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentId { get; set; }
#nullable restore
#else
        public string ContentId { get; set; }
#endif
        /// <summary>The contentName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentName { get; set; }
#nullable restore
#else
        public string ContentName { get; set; }
#endif
        /// <summary>The contentType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>The contentVersion property</summary>
        public int? ContentVersion { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.Feedback"/> and sets the default values.
        /// </summary>
        public Feedback()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.Feedback"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.Feedback CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.Feedback();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "commenterId", n => { CommenterId = n.GetStringValue(); } },
                { "commenterName", n => { CommenterName = n.GetStringValue(); } },
                { "contentAuthorId", n => { ContentAuthorId = n.GetStringValue(); } },
                { "contentAuthorName", n => { ContentAuthorName = n.GetStringValue(); } },
                { "contentId", n => { ContentId = n.GetStringValue(); } },
                { "contentName", n => { ContentName = n.GetStringValue(); } },
                { "contentType", n => { ContentType = n.GetStringValue(); } },
                { "contentVersion", n => { ContentVersion = n.GetIntValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("commenterId", CommenterId);
            writer.WriteStringValue("commenterName", CommenterName);
            writer.WriteStringValue("contentAuthorId", ContentAuthorId);
            writer.WriteStringValue("contentAuthorName", ContentAuthorName);
            writer.WriteStringValue("contentId", ContentId);
            writer.WriteStringValue("contentName", ContentName);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteIntValue("contentVersion", ContentVersion);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("reason", Reason);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
