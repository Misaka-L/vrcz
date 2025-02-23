// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using VRCZ.VRChatApi.Generated.Users.Item.Instances.Groups;
namespace VRCZ.VRChatApi.Generated.Users.Item.Instances
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{user-id}\instances
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InstancesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The groups property</summary>
        public global::VRCZ.VRChatApi.Generated.Users.Item.Instances.Groups.GroupsRequestBuilder Groups
        {
            get => new global::VRCZ.VRChatApi.Generated.Users.Item.Instances.Groups.GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Users.Item.Instances.InstancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstancesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/instances", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Users.Item.Instances.InstancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstancesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/instances", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
