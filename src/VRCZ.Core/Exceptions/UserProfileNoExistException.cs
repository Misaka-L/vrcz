namespace VRCZ.Core.Exceptions;

public class UserProfileNoExistException(string profileId) : Exception
{
    public string ProfileId => profileId;
    public override string Message => $"User profile {ProfileId} does not exist.";
}
