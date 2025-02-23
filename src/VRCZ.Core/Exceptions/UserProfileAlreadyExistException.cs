namespace VRCZ.Core.Exceptions;

public class UserProfileAlreadyExistException(string profileId) : Exception
{
    public string ProfileId => profileId;
    public override string Message => $"User profile {profileId} already exist";
}
