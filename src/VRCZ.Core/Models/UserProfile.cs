using System.Net;
using System.Text.Json.Serialization;

namespace VRCZ.Core.Models;

public class UserProfile
{
    public string Id { get; set; } = "";
    public string DisplayName { get; set; } = "";
    public string Username { get; set; } = "";
    public string AvatarUrl { get; set; } = "";
}

public class UserProfileSecret
{
    public List<Cookie> Cookies { get; set; } = [];
}

[JsonSerializable(typeof(UserProfile))]
[JsonSerializable(typeof(UserProfileSecret))]
public partial class UserProfileContext : JsonSerializerContext
{
}
