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
    public partial class FavoriteLimits : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The defaultMaxFavoriteGroups property</summary>
        public int? DefaultMaxFavoriteGroups { get; set; }
        /// <summary>The defaultMaxFavoritesPerGroup property</summary>
        public int? DefaultMaxFavoritesPerGroup { get; set; }
        /// <summary>The maxFavoriteGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits? MaxFavoriteGroups { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits MaxFavoriteGroups { get; set; }
#endif
        /// <summary>The maxFavoritesPerGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits? MaxFavoritesPerGroup { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits MaxFavoritesPerGroup { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits"/> and sets the default values.
        /// </summary>
        public FavoriteLimits()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "defaultMaxFavoriteGroups", n => { DefaultMaxFavoriteGroups = n.GetIntValue(); } },
                { "defaultMaxFavoritesPerGroup", n => { DefaultMaxFavoritesPerGroup = n.GetIntValue(); } },
                { "maxFavoriteGroups", n => { MaxFavoriteGroups = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits>(global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits.CreateFromDiscriminatorValue); } },
                { "maxFavoritesPerGroup", n => { MaxFavoritesPerGroup = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits>(global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("defaultMaxFavoriteGroups", DefaultMaxFavoriteGroups);
            writer.WriteIntValue("defaultMaxFavoritesPerGroup", DefaultMaxFavoritesPerGroup);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits>("maxFavoriteGroups", MaxFavoriteGroups);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.FavoriteGroupLimits>("maxFavoritesPerGroup", MaxFavoritesPerGroup);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
