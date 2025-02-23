// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using VRCZ.VRChatApi.Generated.Favorite.Group.Item.Item;
namespace VRCZ.VRChatApi.Generated.Favorite.Group.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \favorite\group\{favoriteGroupType}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithFavoriteGroupTypeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the VRCZ.VRChatApi.Generated.favorite.group.item.item collection</summary>
        /// <param name="position">The name of the group to fetch, must be a name of a FavoriteGroup.</param>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Favorite.Group.Item.Item.WithFavoriteGroupNameItemRequestBuilder"/></returns>
        public global::VRCZ.VRChatApi.Generated.Favorite.Group.Item.Item.WithFavoriteGroupNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("favoriteGroupName", position);
                return new global::VRCZ.VRChatApi.Generated.Favorite.Group.Item.Item.WithFavoriteGroupNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Favorite.Group.Item.WithFavoriteGroupTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFavoriteGroupTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/favorite/group/{favoriteGroupType}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Favorite.Group.Item.WithFavoriteGroupTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFavoriteGroupTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/favorite/group/{favoriteGroupType}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
