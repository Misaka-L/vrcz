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
    public partial class LimitedGroup : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bannerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BannerId { get; set; }
#nullable restore
#else
        public string BannerId { get; set; }
#endif
        /// <summary>The bannerUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BannerUrl { get; set; }
#nullable restore
#else
        public string BannerUrl { get; set; }
#endif
        /// <summary>The createdAt property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The discriminator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Discriminator { get; set; }
#nullable restore
#else
        public string Discriminator { get; set; }
#endif
        /// <summary> </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::VRCZ.VRChatApi.Generated.Models.GroupGallery>? Galleries { get; set; }
#nullable restore
#else
        public List<global::VRCZ.VRChatApi.Generated.Models.GroupGallery> Galleries { get; set; }
#endif
        /// <summary>The iconId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IconId { get; set; }
#nullable restore
#else
        public string IconId { get; set; }
#endif
        /// <summary>The iconUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IconUrl { get; set; }
#nullable restore
#else
        public string IconUrl { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>The memberCount property</summary>
        public int? MemberCount { get; set; }
        /// <summary>The membershipStatus property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.GroupMemberStatus? MembershipStatus { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>A users unique ID, usually in the form of `usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469`. Legacy players can have old IDs in the form of `8JoV9XEdpo`. The ID can never be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId { get; set; }
#nullable restore
#else
        public string OwnerId { get; set; }
#endif
        /// <summary>The rules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rules { get; set; }
#nullable restore
#else
        public string Rules { get; set; }
#endif
        /// <summary>The shortCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortCode { get; set; }
#nullable restore
#else
        public string ShortCode { get; set; }
#endif
        /// <summary> </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.LimitedGroup"/> and sets the default values.
        /// </summary>
        public LimitedGroup()
        {
            AdditionalData = new Dictionary<string, object>();
            MembershipStatus = global::VRCZ.VRChatApi.Generated.Models.GroupMemberStatus.Inactive;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.LimitedGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.LimitedGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.LimitedGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bannerId", n => { BannerId = n.GetStringValue(); } },
                { "bannerUrl", n => { BannerUrl = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "discriminator", n => { Discriminator = n.GetStringValue(); } },
                { "galleries", n => { Galleries = n.GetCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.GroupGallery>(global::VRCZ.VRChatApi.Generated.Models.GroupGallery.CreateFromDiscriminatorValue)?.AsList(); } },
                { "iconId", n => { IconId = n.GetStringValue(); } },
                { "iconUrl", n => { IconUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                { "memberCount", n => { MemberCount = n.GetIntValue(); } },
                { "membershipStatus", n => { MembershipStatus = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.GroupMemberStatus>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "ownerId", n => { OwnerId = n.GetStringValue(); } },
                { "rules", n => { Rules = n.GetStringValue(); } },
                { "shortCode", n => { ShortCode = n.GetStringValue(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bannerId", BannerId);
            writer.WriteStringValue("bannerUrl", BannerUrl);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("discriminator", Discriminator);
            writer.WriteCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.GroupGallery>("galleries", Galleries);
            writer.WriteStringValue("iconId", IconId);
            writer.WriteStringValue("iconUrl", IconUrl);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteIntValue("memberCount", MemberCount);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.GroupMemberStatus>("membershipStatus", MembershipStatus);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteStringValue("rules", Rules);
            writer.WriteStringValue("shortCode", ShortCode);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
