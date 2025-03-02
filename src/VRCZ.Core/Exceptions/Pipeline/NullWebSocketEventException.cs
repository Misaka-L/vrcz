namespace VRCZ.Core.Exceptions.Pipeline;

public class NullWebSocketEventException : Exception
{
    public override string Message => "Deserialized WebSocket event is null";
}
