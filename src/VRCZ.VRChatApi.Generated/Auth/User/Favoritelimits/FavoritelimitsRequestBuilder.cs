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
namespace VRCZ.VRChatApi.Generated.Auth.User.Favoritelimits
{
    /// <summary>
    /// Builds and executes requests for operations under \auth\user\favoritelimits
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FavoritelimitsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Auth.User.Favoritelimits.FavoritelimitsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FavoritelimitsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/auth/user/favoritelimits", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Auth.User.Favoritelimits.FavoritelimitsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FavoritelimitsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/auth/user/favoritelimits", rawUrl)
        {
        }
        /// <summary>
        /// Return information about a specific Favorite.
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits>(requestInfo, global::VRCZ.VRChatApi.Generated.Models.FavoriteLimits.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Return information about a specific Favorite.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Auth.User.Favoritelimits.FavoritelimitsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::VRCZ.VRChatApi.Generated.Auth.User.Favoritelimits.FavoritelimitsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::VRCZ.VRChatApi.Generated.Auth.User.Favoritelimits.FavoritelimitsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FavoritelimitsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
