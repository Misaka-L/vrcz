// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using VRCZ.VRChatApi.Generated.Instances.S.Item;
namespace VRCZ.VRChatApi.Generated.Instances.S
{
    /// <summary>
    /// Builds and executes requests for operations under \instances\s
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the VRCZ.VRChatApi.Generated.instances.s.item collection</summary>
        /// <param name="position">Must be a valid instance short name.</param>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Instances.S.Item.WithShortNameItemRequestBuilder"/></returns>
        public global::VRCZ.VRChatApi.Generated.Instances.S.Item.WithShortNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("shortName", position);
                return new global::VRCZ.VRChatApi.Generated.Instances.S.Item.WithShortNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Instances.S.SRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/instances/s", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Instances.S.SRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/instances/s", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
