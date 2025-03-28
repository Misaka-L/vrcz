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
using VRCZ.VRChatApi.Generated.Avatars.Favorites;
using VRCZ.VRChatApi.Generated.Avatars.Impostor;
using VRCZ.VRChatApi.Generated.Avatars.Item;
using VRCZ.VRChatApi.Generated.Avatars.Licensed;
using VRCZ.VRChatApi.Generated.Models;
namespace VRCZ.VRChatApi.Generated.Avatars
{
    /// <summary>
    /// Builds and executes requests for operations under \avatars
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AvatarsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The favorites property</summary>
        public global::VRCZ.VRChatApi.Generated.Avatars.Favorites.FavoritesRequestBuilder Favorites
        {
            get => new global::VRCZ.VRChatApi.Generated.Avatars.Favorites.FavoritesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The impostor property</summary>
        public global::VRCZ.VRChatApi.Generated.Avatars.Impostor.ImpostorRequestBuilder Impostor
        {
            get => new global::VRCZ.VRChatApi.Generated.Avatars.Impostor.ImpostorRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The licensed property</summary>
        public global::VRCZ.VRChatApi.Generated.Avatars.Licensed.LicensedRequestBuilder Licensed
        {
            get => new global::VRCZ.VRChatApi.Generated.Avatars.Licensed.LicensedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the VRCZ.VRChatApi.Generated.avatars.item collection</summary>
        /// <param name="position">Must be a valid avatar ID.</param>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Avatars.Item.WithAvatarItemRequestBuilder"/></returns>
        public global::VRCZ.VRChatApi.Generated.Avatars.Item.WithAvatarItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("avatarId", position);
                return new global::VRCZ.VRChatApi.Generated.Avatars.Item.WithAvatarItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AvatarsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/avatars{?featured*,maxUnityVersion*,minUnityVersion*,n*,notag*,offset*,order*,platform*,releaseStatus*,sort*,tag*,user*,userId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AvatarsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/avatars{?featured*,maxUnityVersion*,minUnityVersion*,n*,notag*,offset*,order*,platform*,releaseStatus*,sort*,tag*,user*,userId*}", rawUrl)
        {
        }
        /// <summary>
        /// Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </summary>
        /// <returns>A List&lt;global::VRCZ.VRChatApi.Generated.Models.Avatar&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.Avatar>?> GetAsync(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder.AvatarsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.Avatar>> GetAsync(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder.AvatarsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::VRCZ.VRChatApi.Generated.Models.Avatar>(requestInfo, global::VRCZ.VRChatApi.Generated.Models.Avatar.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Create an avatar. It&apos;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.Avatar"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::VRCZ.VRChatApi.Generated.Models.Avatar?> PostAsync(global::VRCZ.VRChatApi.Generated.Models.CreateAvatarRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::VRCZ.VRChatApi.Generated.Models.Avatar> PostAsync(global::VRCZ.VRChatApi.Generated.Models.CreateAvatarRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::VRCZ.VRChatApi.Generated.Models.Avatar>(requestInfo, global::VRCZ.VRChatApi.Generated.Models.Avatar.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder.AvatarsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder.AvatarsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create an avatar. It&apos;s possible to optionally specify a ID if you want a custom one. Attempting to create an Avatar with an already claimed ID will result in a DB error.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::VRCZ.VRChatApi.Generated.Models.CreateAvatarRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::VRCZ.VRChatApi.Generated.Models.CreateAvatarRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Search and list avatars by query filters. You can only search your own or featured avatars. It is not possible as a normal user to search other peoples avatars.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AvatarsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filters on featured results.</summary>
            [QueryParameter("featured")]
            public bool? Featured { get; set; }
            /// <summary>The maximum Unity version supported by the asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("maxUnityVersion")]
            public string? MaxUnityVersion { get; set; }
#nullable restore
#else
            [QueryParameter("maxUnityVersion")]
            public string MaxUnityVersion { get; set; }
#endif
            /// <summary>The minimum Unity version supported by the asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("minUnityVersion")]
            public string? MinUnityVersion { get; set; }
#nullable restore
#else
            [QueryParameter("minUnityVersion")]
            public string MinUnityVersion { get; set; }
#endif
            /// <summary>The number of objects to return.</summary>
            [QueryParameter("n")]
            public int? N { get; set; }
            /// <summary>Tags to exclude (comma-separated).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("notag")]
            public string? Notag { get; set; }
#nullable restore
#else
            [QueryParameter("notag")]
            public string Notag { get; set; }
#endif
            /// <summary>A zero-based offset from the default object sorting from where search results start.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>Result ordering</summary>
            [Obsolete("This property is deprecated, use OrderAsOrderOption instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order")]
            public string? Order { get; set; }
#nullable restore
#else
            [QueryParameter("order")]
            public string Order { get; set; }
#endif
            /// <summary>Result ordering</summary>
            [QueryParameter("order")]
            public global::VRCZ.VRChatApi.Generated.Models.OrderOption? OrderAsOrderOption { get; set; }
            /// <summary>The platform the asset supports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("platform")]
            public string? Platform { get; set; }
#nullable restore
#else
            [QueryParameter("platform")]
            public string Platform { get; set; }
#endif
            /// <summary>Filter by ReleaseStatus.</summary>
            [Obsolete("This property is deprecated, use ReleaseStatusAsReleaseStatus instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("releaseStatus")]
            public string? ReleaseStatus { get; set; }
#nullable restore
#else
            [QueryParameter("releaseStatus")]
            public string ReleaseStatus { get; set; }
#endif
            /// <summary>Filter by ReleaseStatus.</summary>
            [QueryParameter("releaseStatus")]
            public global::VRCZ.VRChatApi.Generated.Models.ReleaseStatus? ReleaseStatusAsReleaseStatus { get; set; }
            /// <summary>The sort order of the results.</summary>
            [Obsolete("This property is deprecated, use SortAsSortOption instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>The sort order of the results.</summary>
            [QueryParameter("sort")]
            public global::VRCZ.VRChatApi.Generated.Models.SortOption? SortAsSortOption { get; set; }
            /// <summary>Tags to include (comma-separated). Any of the tags needs to be present.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tag")]
            public string? Tag { get; set; }
#nullable restore
#else
            [QueryParameter("tag")]
            public string Tag { get; set; }
#endif
            /// <summary>Set to `me` for searching own avatars.</summary>
            [Obsolete("This property is deprecated, use UserAsGetUserQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user")]
            public string? User { get; set; }
#nullable restore
#else
            [QueryParameter("user")]
            public string User { get; set; }
#endif
            /// <summary>Set to `me` for searching own avatars.</summary>
            [QueryParameter("user")]
            public global::VRCZ.VRChatApi.Generated.Avatars.GetUserQueryParameterType? UserAsGetUserQueryParameterType { get; set; }
            /// <summary>Filter by UserID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("userId")]
            public string? UserId { get; set; }
#nullable restore
#else
            [QueryParameter("userId")]
            public string UserId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AvatarsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::VRCZ.VRChatApi.Generated.Avatars.AvatarsRequestBuilder.AvatarsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AvatarsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
