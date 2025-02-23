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
    public partial class Jam_stateChangeDates : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The closed property</summary>
        public DateTimeOffset? Closed { get; set; }
        /// <summary>The submissionsClosed property</summary>
        public DateTimeOffset? SubmissionsClosed { get; set; }
        /// <summary>The submissionsOpened property</summary>
        public DateTimeOffset? SubmissionsOpened { get; set; }
        /// <summary>The winnersSelected property</summary>
        public DateTimeOffset? WinnersSelected { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.Jam_stateChangeDates"/> and sets the default values.
        /// </summary>
        public Jam_stateChangeDates()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.Jam_stateChangeDates"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.Jam_stateChangeDates CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.Jam_stateChangeDates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "closed", n => { Closed = n.GetDateTimeOffsetValue(); } },
                { "submissionsClosed", n => { SubmissionsClosed = n.GetDateTimeOffsetValue(); } },
                { "submissionsOpened", n => { SubmissionsOpened = n.GetDateTimeOffsetValue(); } },
                { "winnersSelected", n => { WinnersSelected = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("closed", Closed);
            writer.WriteDateTimeOffsetValue("submissionsClosed", SubmissionsClosed);
            writer.WriteDateTimeOffsetValue("submissionsOpened", SubmissionsOpened);
            writer.WriteDateTimeOffsetValue("winnersSelected", WinnersSelected);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
