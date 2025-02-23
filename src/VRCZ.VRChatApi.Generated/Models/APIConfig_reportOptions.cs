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
    /// Options for reporting content
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class APIConfig_reportOptions : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The avatar property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_avatar? Avatar { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_avatar Avatar { get; set; }
#endif
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_group? Group { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_group Group { get; set; }
#endif
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_user? User { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_user User { get; set; }
#endif
        /// <summary>The world property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_world? World { get; set; }
#nullable restore
#else
        public global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_world World { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions"/> and sets the default values.
        /// </summary>
        public APIConfig_reportOptions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "avatar", n => { Avatar = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_avatar>(global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_avatar.CreateFromDiscriminatorValue); } },
                { "group", n => { Group = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_group>(global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_group.CreateFromDiscriminatorValue); } },
                { "user", n => { User = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_user>(global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_user.CreateFromDiscriminatorValue); } },
                { "world", n => { World = n.GetObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_world>(global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_world.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_avatar>("avatar", Avatar);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_group>("group", Group);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_user>("user", User);
            writer.WriteObjectValue<global::VRCZ.VRChatApi.Generated.Models.APIConfig_reportOptions_world>("world", World);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
