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
    public partial class Subscription : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The googlePlanId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GooglePlanId { get; set; }
#nullable restore
#else
        public string GooglePlanId { get; set; }
#endif
        /// <summary>The googleProductId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GoogleProductId { get; set; }
#nullable restore
#else
        public string GoogleProductId { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The oculusSku property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OculusSku { get; set; }
#nullable restore
#else
        public string OculusSku { get; set; }
#endif
        /// <summary>The period property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.SubscriptionPeriod? Period { get; set; }
        /// <summary>The picoSku property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PicoSku { get; set; }
#nullable restore
#else
        public string PicoSku { get; set; }
#endif
        /// <summary>The steamItemId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SteamItemId { get; set; }
#nullable restore
#else
        public string SteamItemId { get; set; }
#endif
        /// <summary>The tier property</summary>
        public int? Tier { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.Subscription"/> and sets the default values.
        /// </summary>
        public Subscription()
        {
            AdditionalData = new Dictionary<string, object>();
            Period = global::VRCZ.VRChatApi.Generated.Models.SubscriptionPeriod.Month;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.Subscription"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.Subscription CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.Subscription();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "googlePlanId", n => { GooglePlanId = n.GetStringValue(); } },
                { "googleProductId", n => { GoogleProductId = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "oculusSku", n => { OculusSku = n.GetStringValue(); } },
                { "period", n => { Period = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.SubscriptionPeriod>(); } },
                { "picoSku", n => { PicoSku = n.GetStringValue(); } },
                { "steamItemId", n => { SteamItemId = n.GetStringValue(); } },
                { "tier", n => { Tier = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("googlePlanId", GooglePlanId);
            writer.WriteStringValue("googleProductId", GoogleProductId);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("oculusSku", OculusSku);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.SubscriptionPeriod>("period", Period);
            writer.WriteStringValue("picoSku", PicoSku);
            writer.WriteStringValue("steamItemId", SteamItemId);
            writer.WriteIntValue("tier", Tier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
