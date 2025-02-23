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
    public partial class Badge : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>only present in CurrentUser badges</summary>
        public DateTimeOffset? AssignedAt { get; set; }
        /// <summary>The badgeDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BadgeDescription { get; set; }
#nullable restore
#else
        public string BadgeDescription { get; set; }
#endif
        /// <summary>The badgeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BadgeId { get; set; }
#nullable restore
#else
        public string BadgeId { get; set; }
#endif
        /// <summary>direct url to image</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BadgeImageUrl { get; set; }
#nullable restore
#else
        public string BadgeImageUrl { get; set; }
#endif
        /// <summary>The badgeName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BadgeName { get; set; }
#nullable restore
#else
        public string BadgeName { get; set; }
#endif
        /// <summary>only present in CurrentUser badges</summary>
        public bool? Hidden { get; set; }
        /// <summary>The showcased property</summary>
        public bool? Showcased { get; set; }
        /// <summary>only present in CurrentUser badges</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.Badge"/> and sets the default values.
        /// </summary>
        public Badge()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.Badge"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.Badge CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.Badge();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignedAt", n => { AssignedAt = n.GetDateTimeOffsetValue(); } },
                { "badgeDescription", n => { BadgeDescription = n.GetStringValue(); } },
                { "badgeId", n => { BadgeId = n.GetStringValue(); } },
                { "badgeImageUrl", n => { BadgeImageUrl = n.GetStringValue(); } },
                { "badgeName", n => { BadgeName = n.GetStringValue(); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "showcased", n => { Showcased = n.GetBoolValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("assignedAt", AssignedAt);
            writer.WriteStringValue("badgeDescription", BadgeDescription);
            writer.WriteStringValue("badgeId", BadgeId);
            writer.WriteStringValue("badgeImageUrl", BadgeImageUrl);
            writer.WriteStringValue("badgeName", BadgeName);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteBoolValue("showcased", Showcased);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
