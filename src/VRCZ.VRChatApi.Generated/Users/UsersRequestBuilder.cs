// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
using VRCZ.VRChatApi.Generated.Models;
using VRCZ.VRChatApi.Generated.Users.Item;
namespace VRCZ.VRChatApi.Generated.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the VRCZ.VRChatApi.Generated.users.item collection</summary>
        /// <param name="position">Must be a valid user ID.</param>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Users.Item.UserItemRequestBuilder"/></returns>
        public global::VRCZ.VRChatApi.Generated.Users.Item.UserItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("user%2Did", position);
                return new global::VRCZ.VRChatApi.Generated.Users.Item.UserItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?developerType*,n*,offset*,search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?developerType*,n*,offset*,search*}", rawUrl)
        {
        }
        /// <summary>
        /// Search and list any users by text query
        /// </summary>
        /// <returns>A List&lt;global::VRCZ.VRChatApi.Generated.Models.LimitedUser&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 400 status code</exception>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.LimitedUser>?> GetAsync(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.LimitedUser>> GetAsync(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
                { "401", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::VRCZ.VRChatApi.Generated.Models.LimitedUser>(requestInfo, global::VRCZ.VRChatApi.Generated.Models.LimitedUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Search and list any users by text query
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Search and list any users by text query
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>Active user by developer type, none for normal users and internal for moderators</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("developerType")]
            public string? DeveloperType { get; set; }
#nullable restore
#else
            [QueryParameter("developerType")]
            public string DeveloperType { get; set; }
#endif
            /// <summary>The number of objects to return.</summary>
            [QueryParameter("n")]
            public int? N { get; set; }
            /// <summary>A zero-based offset from the default object sorting from where search results start.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>Searches by `displayName`. Will return empty array if search query is empty or missing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
