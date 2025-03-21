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
    public partial class DynamicContentRow : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The index property</summary>
        public int? Index { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Usually &quot;ThisPlatformSupported&quot;, but can also be other values such as &quot;all&quot; or platform specific identifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Platform { get; set; }
#nullable restore
#else
        public string Platform { get; set; }
#endif
        /// <summary>The sortHeading property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SortHeading { get; set; }
#nullable restore
#else
        public string SortHeading { get; set; }
#endif
        /// <summary>The sortOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SortOrder { get; set; }
#nullable restore
#else
        public string SortOrder { get; set; }
#endif
        /// <summary>The sortOwnership property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SortOwnership { get; set; }
#nullable restore
#else
        public string SortOwnership { get; set; }
#endif
        /// <summary>Tag to filter content for this row.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tag { get; set; }
#nullable restore
#else
        public string Tag { get; set; }
#endif
        /// <summary>Type is not present if it is a world.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow"/> and sets the default values.
        /// </summary>
        public DynamicContentRow()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.DynamicContentRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "index", n => { Index = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "platform", n => { Platform = n.GetStringValue(); } },
                { "sortHeading", n => { SortHeading = n.GetStringValue(); } },
                { "sortOrder", n => { SortOrder = n.GetStringValue(); } },
                { "sortOwnership", n => { SortOwnership = n.GetStringValue(); } },
                { "tag", n => { Tag = n.GetStringValue(); } },
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
            writer.WriteIntValue("index", Index);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("platform", Platform);
            writer.WriteStringValue("sortHeading", SortHeading);
            writer.WriteStringValue("sortOrder", SortOrder);
            writer.WriteStringValue("sortOwnership", SortOwnership);
            writer.WriteStringValue("tag", Tag);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
