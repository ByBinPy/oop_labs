using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class DestinationFilter : IDestination
{
    private readonly int _recipientPriority;
    private readonly IDestination _destination;
    public DestinationFilter(int recipientPriority, DestinationLogging destinationLogging)
    {
        _recipientPriority = recipientPriority;
        _destination = destinationLogging;
    }

    public void SendMessage(IMessage message)
    {
        if (_recipientPriority >= message.Priority)
            _destination.SendMessage(message);
    }
}