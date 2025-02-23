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
    public partial class ProductListing : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The archived property</summary>
        public bool? Archived { get; set; }
        /// <summary>The buyerRefundable property</summary>
        public bool? BuyerRefundable { get; set; }
        /// <summary>The created property</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The duration property</summary>
        public int? Duration { get; set; }
        /// <summary>The durationType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DurationType { get; set; }
#nullable restore
#else
        public string DurationType { get; set; }
#endif
        /// <summary>The groupIcon property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupIcon { get; set; }
#nullable restore
#else
        public string GroupIcon { get; set; }
#endif
        /// <summary>The groupId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId { get; set; }
#nullable restore
#else
        public string GroupId { get; set; }
#endif
        /// <summary>The groupName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupName { get; set; }
#nullable restore
#else
        public string GroupName { get; set; }
#endif
        /// <summary>The hydratedProducts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::VRCZ.VRChatApi.Generated.Models.Product>? HydratedProducts { get; set; }
#nullable restore
#else
        public List<global::VRCZ.VRChatApi.Generated.Models.Product> HydratedProducts { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The imageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageId { get; set; }
#nullable restore
#else
        public string ImageId { get; set; }
#endif
        /// <summary>The instant property</summary>
        public bool? Instant { get; set; }
        /// <summary>The listingType property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.ProductListingType? ListingType { get; set; }
        /// <summary>The listingVariants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::VRCZ.VRChatApi.Generated.Models.ProductListingVariant>? ListingVariants { get; set; }
#nullable restore
#else
        public List<global::VRCZ.VRChatApi.Generated.Models.ProductListingVariant> ListingVariants { get; set; }
#endif
        /// <summary>The permanent property</summary>
        public bool? Permanent { get; set; }
        /// <summary>The priceTokens property</summary>
        public int? PriceTokens { get; set; }
        /// <summary>The productIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProductIds { get; set; }
#nullable restore
#else
        public List<string> ProductIds { get; set; }
#endif
        /// <summary>The products property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::VRCZ.VRChatApi.Generated.Models.ProductListing_products>? Products { get; set; }
#nullable restore
#else
        public List<global::VRCZ.VRChatApi.Generated.Models.ProductListing_products> Products { get; set; }
#endif
        /// <summary>The productType property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.ProductType? ProductType { get; set; }
        /// <summary>The quantifiable property</summary>
        public bool? Quantifiable { get; set; }
        /// <summary>The recurrable property</summary>
        public bool? Recurrable { get; set; }
        /// <summary>The refundable property</summary>
        public bool? Refundable { get; set; }
        /// <summary>The sellerDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SellerDisplayName { get; set; }
#nullable restore
#else
        public string SellerDisplayName { get; set; }
#endif
        /// <summary>The sellerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SellerId { get; set; }
#nullable restore
#else
        public string SellerId { get; set; }
#endif
        /// <summary>The stackable property</summary>
        public bool? Stackable { get; set; }
        /// <summary>The storeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StoreIds { get; set; }
#nullable restore
#else
        public List<string> StoreIds { get; set; }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The updated property</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.ProductListing"/> and sets the default values.
        /// </summary>
        public ProductListing()
        {
            AdditionalData = new Dictionary<string, object>();
            ListingType = global::VRCZ.VRChatApi.Generated.Models.ProductListingType.Subscription;
            ProductType = global::VRCZ.VRChatApi.Generated.Models.ProductType.Udon;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.ProductListing"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.ProductListing CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.ProductListing();
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
                { "archived", n => { Archived = n.GetBoolValue(); } },
                { "buyerRefundable", n => { BuyerRefundable = n.GetBoolValue(); } },
                { "created", n => { Created = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "duration", n => { Duration = n.GetIntValue(); } },
                { "durationType", n => { DurationType = n.GetStringValue(); } },
                { "groupIcon", n => { GroupIcon = n.GetStringValue(); } },
                { "groupId", n => { GroupId = n.GetStringValue(); } },
                { "groupName", n => { GroupName = n.GetStringValue(); } },
                { "hydratedProducts", n => { HydratedProducts = n.GetCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.Product>(global::VRCZ.VRChatApi.Generated.Models.Product.CreateFromDiscriminatorValue)?.AsList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "imageId", n => { ImageId = n.GetStringValue(); } },
                { "instant", n => { Instant = n.GetBoolValue(); } },
                { "listingType", n => { ListingType = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.ProductListingType>(); } },
                { "listingVariants", n => { ListingVariants = n.GetCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.ProductListingVariant>(global::VRCZ.VRChatApi.Generated.Models.ProductListingVariant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "permanent", n => { Permanent = n.GetBoolValue(); } },
                { "priceTokens", n => { PriceTokens = n.GetIntValue(); } },
                { "productIds", n => { ProductIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "productType", n => { ProductType = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.ProductType>(); } },
                { "products", n => { Products = n.GetCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.ProductListing_products>(global::VRCZ.VRChatApi.Generated.Models.ProductListing_products.CreateFromDiscriminatorValue)?.AsList(); } },
                { "quantifiable", n => { Quantifiable = n.GetBoolValue(); } },
                { "recurrable", n => { Recurrable = n.GetBoolValue(); } },
                { "refundable", n => { Refundable = n.GetBoolValue(); } },
                { "sellerDisplayName", n => { SellerDisplayName = n.GetStringValue(); } },
                { "sellerId", n => { SellerId = n.GetStringValue(); } },
                { "stackable", n => { Stackable = n.GetBoolValue(); } },
                { "storeIds", n => { StoreIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteBoolValue("archived", Archived);
            writer.WriteBoolValue("buyerRefundable", BuyerRefundable);
            writer.WriteDateTimeOffsetValue("created", Created);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("duration", Duration);
            writer.WriteStringValue("durationType", DurationType);
            writer.WriteStringValue("groupIcon", GroupIcon);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("groupName", GroupName);
            writer.WriteCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.Product>("hydratedProducts", HydratedProducts);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("imageId", ImageId);
            writer.WriteBoolValue("instant", Instant);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.ProductListingType>("listingType", ListingType);
            writer.WriteCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.ProductListingVariant>("listingVariants", ListingVariants);
            writer.WriteBoolValue("permanent", Permanent);
            writer.WriteIntValue("priceTokens", PriceTokens);
            writer.WriteCollectionOfPrimitiveValues<string>("productIds", ProductIds);
            writer.WriteCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.ProductListing_products>("products", Products);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.ProductType>("productType", ProductType);
            writer.WriteBoolValue("quantifiable", Quantifiable);
            writer.WriteBoolValue("recurrable", Recurrable);
            writer.WriteBoolValue("refundable", Refundable);
            writer.WriteStringValue("sellerDisplayName", SellerDisplayName);
            writer.WriteStringValue("sellerId", SellerId);
            writer.WriteBoolValue("stackable", Stackable);
            writer.WriteCollectionOfPrimitiveValues<string>("storeIds", StoreIds);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
