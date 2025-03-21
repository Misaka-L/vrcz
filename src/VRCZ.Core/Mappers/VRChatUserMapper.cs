using Riok.Mapperly.Abstractions;
using VRCZ.VRChatApi.Generated.Models;

namespace VRCZ.Core.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.None)]
public static partial class VRChatUserMapper
{
    public static partial CurrentUser UserToCurrentUser(User user);
}
