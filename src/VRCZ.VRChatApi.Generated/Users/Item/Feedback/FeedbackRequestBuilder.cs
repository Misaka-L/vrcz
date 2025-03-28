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
namespace VRCZ.VRChatApi.Generated.Users.Item.Feedback
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{user-id}\feedback
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FeedbackRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FeedbackRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/feedback{?contentId*,n*,offset*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FeedbackRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/feedback{?contentId*,n*,offset*}", rawUrl)
        {
        }
        /// <summary>
        /// Get user&apos;s submitted feedback
        /// </summary>
        /// <returns>A List&lt;global::VRCZ.VRChatApi.Generated.Models.Feedback&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 401 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.Feedback>?> GetAsync(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder.FeedbackRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.Feedback>> GetAsync(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder.FeedbackRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::VRCZ.VRChatApi.Generated.Models.Feedback>(requestInfo, global::VRCZ.VRChatApi.Generated.Models.Feedback.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get user&apos;s submitted feedback
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder.FeedbackRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder.FeedbackRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder WithUrl(string rawUrl)
        {
            return new global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get user&apos;s submitted feedback
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FeedbackRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter for users&apos; previously submitted feedback, e.g., a groupId, useeId, avatarId, etc.</summary>
            [QueryParameter("contentId")]
            public bool? ContentId { get; set; }
            /// <summary>The number of objects to return.</summary>
            [QueryParameter("n")]
            public int? N { get; set; }
            /// <summary>A zero-based offset from the default object sorting from where search results start.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FeedbackRequestBuilderGetRequestConfiguration : RequestConfiguration<global::VRCZ.VRChatApi.Generated.Users.Item.Feedback.FeedbackRequestBuilder.FeedbackRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
