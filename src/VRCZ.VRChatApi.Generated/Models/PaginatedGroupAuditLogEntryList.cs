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
    public partial class PaginatedGroupAuditLogEntryList : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether there are more results after this page.</summary>
        public bool? HasNext { get; set; }
        /// <summary> </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::VRCZ.VRChatApi.Generated.Models.GroupAuditLogEntry>? Results { get; set; }
#nullable restore
#else
        public List<global::VRCZ.VRChatApi.Generated.Models.GroupAuditLogEntry> Results { get; set; }
#endif
        /// <summary>The total number of results that the query would return if there were no pagination.</summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.PaginatedGroupAuditLogEntryList"/> and sets the default values.
        /// </summary>
        public PaginatedGroupAuditLogEntryList()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.PaginatedGroupAuditLogEntryList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.PaginatedGroupAuditLogEntryList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.PaginatedGroupAuditLogEntryList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "hasNext", n => { HasNext = n.GetBoolValue(); } },
                { "results", n => { Results = n.GetCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.GroupAuditLogEntry>(global::VRCZ.VRChatApi.Generated.Models.GroupAuditLogEntry.CreateFromDiscriminatorValue)?.AsList(); } },
                { "totalCount", n => { TotalCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hasNext", HasNext);
            writer.WriteCollectionOfObjectValues<global::VRCZ.VRChatApi.Generated.Models.GroupAuditLogEntry>("results", Results);
            writer.WriteIntValue("totalCount", TotalCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
