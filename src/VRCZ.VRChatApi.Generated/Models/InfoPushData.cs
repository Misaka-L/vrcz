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
    public partial class InfoPushData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The article property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.InfoPushDataArticle? Article { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.InfoPushDataArticle Article { get; set; }
#endif
        /// <summary>The contentList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow? ContentList { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow ContentList { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The imageUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl { get; set; }
#nullable restore
#else
        public string ImageUrl { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The onPressed property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.InfoPushDataClickable? OnPressed { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.InfoPushDataClickable OnPressed { get; set; }
#endif
        /// <summary>The template property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Template { get; set; }
#nullable restore
#else
        public string Template { get; set; }
#endif
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.InfoPushData"/> and sets the default values.
        /// </summary>
        public InfoPushData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.InfoPushData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.InfoPushData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.InfoPushData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "article", n => { Article = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.InfoPushDataArticle>(global::VRCZ.VRChatApi.Generated.Models.InfoPushDataArticle.CreateFromDiscriminatorValue); } },
                { "contentList", n => { ContentList = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow>(global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "imageUrl", n => { ImageUrl = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "onPressed", n => { OnPressed = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.InfoPushDataClickable>(global::VRCZ.VRChatApi.Generated.Models.InfoPushDataClickable.CreateFromDiscriminatorValue); } },
                { "template", n => { Template = n.GetStringValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.InfoPushDataArticle>("article", Article);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow>("contentList", ContentList);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("imageUrl", ImageUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.InfoPushDataClickable>("onPressed", OnPressed);
            writer.WriteStringValue("template", Template);
            writer.WriteStringValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
