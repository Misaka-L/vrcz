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
    /// Group-related constants
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class APIConfigConstants_GROUPS : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Maximum group capacity</summary>
        public int? CAPACITY { get; set; }
        /// <summary>Requirements for transferring group ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GROUPTRANSFERREQUIREMENTS { get; set; }
#nullable restore
#else
        public List<string> GROUPTRANSFERREQUIREMENTS { get; set; }
#endif
        /// <summary>Maximum number of invite requests</summary>
        public int? MAXINVITESREQUESTS { get; set; }
        /// <summary>Maximum number of joined groups</summary>
        public int? MAXJOINED { get; set; }
        /// <summary>Maximum number of joined groups for VRChat Plus members</summary>
        public int? MAXJOINEDPLUS { get; set; }
        /// <summary>Maximum number of supported languages</summary>
        public int? MAXLANGUAGES { get; set; }
        /// <summary>Maximum number of group links</summary>
        public int? MAXLINKS { get; set; }
        /// <summary>Maximum number of management roles in a group</summary>
        public int? MAXMANAGEMENTROLES { get; set; }
        /// <summary>Maximum number of groups a user can own</summary>
        public int? MAXOWNED { get; set; }
        /// <summary>Maximum number of roles in a group</summary>
        public int? MAXROLES { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_GROUPS"/> and sets the default values.
        /// </summary>
        public APIConfigConstants_GROUPS()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_GROUPS"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_GROUPS CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.APIConfigConstants_GROUPS();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "CAPACITY", n => { CAPACITY = n.GetIntValue(); } },
                { "GROUP_TRANSFER_REQUIREMENTS", n => { GROUPTRANSFERREQUIREMENTS = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "MAX_INVITES_REQUESTS", n => { MAXINVITESREQUESTS = n.GetIntValue(); } },
                { "MAX_JOINED", n => { MAXJOINED = n.GetIntValue(); } },
                { "MAX_JOINED_PLUS", n => { MAXJOINEDPLUS = n.GetIntValue(); } },
                { "MAX_LANGUAGES", n => { MAXLANGUAGES = n.GetIntValue(); } },
                { "MAX_LINKS", n => { MAXLINKS = n.GetIntValue(); } },
                { "MAX_MANAGEMENT_ROLES", n => { MAXMANAGEMENTROLES = n.GetIntValue(); } },
                { "MAX_OWNED", n => { MAXOWNED = n.GetIntValue(); } },
                { "MAX_ROLES", n => { MAXROLES = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("CAPACITY", CAPACITY);
            writer.WriteCollectionOfPrimitiveValues<string>("GROUP_TRANSFER_REQUIREMENTS", GROUPTRANSFERREQUIREMENTS);
            writer.WriteIntValue("MAX_INVITES_REQUESTS", MAXINVITESREQUESTS);
            writer.WriteIntValue("MAX_JOINED", MAXJOINED);
            writer.WriteIntValue("MAX_JOINED_PLUS", MAXJOINEDPLUS);
            writer.WriteIntValue("MAX_LANGUAGES", MAXLANGUAGES);
            writer.WriteIntValue("MAX_LINKS", MAXLINKS);
            writer.WriteIntValue("MAX_MANAGEMENT_ROLES", MAXMANAGEMENTROLES);
            writer.WriteIntValue("MAX_OWNED", MAXOWNED);
            writer.WriteIntValue("MAX_ROLES", MAXROLES);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
