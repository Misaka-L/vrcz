// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace VRCZ.VRChatApi.Generated.Models
{
    /// <summary>
    /// Language-related constants
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class APIConfigConstants_LANGUAGE : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Supported spoken language options</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE_SPOKEN_LANGUAGE_OPTIONS? SPOKENLANGUAGEOPTIONS { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE_SPOKEN_LANGUAGE_OPTIONS SPOKENLANGUAGEOPTIONS { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE"/> and sets the default values.
        /// </summary>
        public APIConfigConstants_LANGUAGE()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "SPOKEN_LANGUAGE_OPTIONS", n => { SPOKENLANGUAGEOPTIONS = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE_SPOKEN_LANGUAGE_OPTIONS>(global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE_SPOKEN_LANGUAGE_OPTIONS.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_LANGUAGE_SPOKEN_LANGUAGE_OPTIONS>("SPOKEN_LANGUAGE_OPTIONS", SPOKENLANGUAGEOPTIONS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
