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
using VRCZ.VRChatApi.Generated.Message.Item.Item.Item;
using VRCZ.VRChatApi.Generated.Models;
namespace VRCZ.VRChatApi.Generated.Message.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \message\{userId}\{messageType}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithMessageTypeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the VRCZ.VRChatApi.Generated.message.item.item.item collection</summary>
        /// <param name="position">The message slot to fetch of a given message type.</param>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Message.Item.Item.Item.WithSlotItemRequestBuilder"/></returns>
        public global::VRCZ.VRChatApi.Generated.Message.Item.Item.Item.WithSlotItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("slot", position);
                return new global::VRCZ.VRChatApi.Generated.Message.Item.Item.Item.WithSlotItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the VRCZ.VRChatApi.Generated.message.item.item.item collection</summary>
        /// <param name="position">The message slot to fetch of a given message type.</param>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Message.Item.Item.Item.WithSlotItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::VRCZ.VRChatApi.Generated.Message.Item.Item.Item.WithSlotItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("slot", position);
                return new global::VRCZ.VRChatApi.Generated.Message.Item.Item.Item.WithSlotItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Message.Item.Item.WithMessageTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMessageTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/message/{userId}/{messageType}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Message.Item.Item.WithMessageTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMessageTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/message/{userId}/{messageType}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of all the users Invite Messages. Admin Credentials are required to view messages of other users!Message type refers to a different collection of messages, used during different types of responses.* `message` = Message during a normal invite* `response` = Message when replying to a message* `request` = Message when requesting an invite* `requestResponse` = Message when replying to a request for invite
        /// </summary>
        /// <returns>A List&lt;global::VRCZ.VRChatApi.Generated.Models.InviteMessage&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 400 status code</exception>
        /// <exception cref="global::VRCZ.VRChatApi.Generated.Models.Error">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.InviteMessage>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::VRCZ.VRChatApi.Generated.Models.InviteMessage>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
                { "401", global::VRCZ.VRChatApi.Generated.Models.Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::VRCZ.VRChatApi.Generated.Models.InviteMessage>(requestInfo, global::VRCZ.VRChatApi.Generated.Models.InviteMessage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Returns a list of all the users Invite Messages. Admin Credentials are required to view messages of other users!Message type refers to a different collection of messages, used during different types of responses.* `message` = Message during a normal invite* `response` = Message when replying to a message* `request` = Message when requesting an invite* `requestResponse` = Message when replying to a request for invite
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
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Message.Item.Item.WithMessageTypeItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::VRCZ.VRChatApi.Generated.Message.Item.Item.WithMessageTypeItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::VRCZ.VRChatApi.Generated.Message.Item.Item.WithMessageTypeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithMessageTypeItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
