namespace VRCZ.Core.Exceptions.Pipeline;

public class UnknownNotificationTypeException(string eventType) : Exception
{
    public string EventType => eventType;
    public override string Message => $"Unknown notification type: {eventType}";
}
