using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class DestinationFilter : IDestination
{
    private readonly int _recipientPriority;
    private readonly DestinationLogging _destinationLogging;
    public DestinationFilter(int recipientPriority, DestinationLogging destinationLogging)
    {
        _recipientPriority = recipientPriority;
        _destinationLogging = destinationLogging;
    }

    public void SendMessage(IMessage message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));

        if (_recipientPriority >= message.Priority)
            _destinationLogging.SendMessage(message);
    }
}