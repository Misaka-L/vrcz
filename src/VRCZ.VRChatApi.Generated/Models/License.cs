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
    public partial class License : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The forAction property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.LicenseAction? ForAction { get; set; }
        /// <summary>Either a AvatarID, LicenseGroupID, PermissionID or ProductID. This depends on the `forType` field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForId { get; set; }
#nullable restore
#else
        public string ForId { get; set; }
#endif
        /// <summary>The forName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForName { get; set; }
#nullable restore
#else
        public string ForName { get; set; }
#endif
        /// <summary>The forType property</summary>
        public global::VRCZ.VRChatApi.Generated.Models.LicenseType? ForType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.License"/> and sets the default values.
        /// </summary>
        public License()
        {
            AdditionalData = new Dictionary<string, object>();
            ForAction = global::VRCZ.VRChatApi.Generated.Models.LicenseAction.Have;
            ForType = global::VRCZ.VRChatApi.Generated.Models.LicenseType.Permission;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.License"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.License CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.License();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "forAction", n => { ForAction = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.LicenseAction>(); } },
                { "forId", n => { ForId = n.GetStringValue(); } },
                { "forName", n => { ForName = n.GetStringValue(); } },
                { "forType", n => { ForType = n.GetEnumValue<global::VRCZ.VRChatApi.Generated.Models.LicenseType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.LicenseAction>("forAction", ForAction);
            writer.WriteStringValue("forId", ForId);
            writer.WriteStringValue("forName", ForName);
            writer.WriteEnumValue<global::VRCZ.VRChatApi.Generated.Models.LicenseType>("forType", ForType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
