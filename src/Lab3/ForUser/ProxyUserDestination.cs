using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class ProxyUserDestination : IDestination
{
    private readonly UserDestination _destination;
    private readonly ILogger _logger;

    public ProxyUserDestination(UserDestination destination)
    {
        _logger = new Logger();
        _destination = destination;
    }

    public ProxyUserDestination(UserDestination destination, ILogger logger)
    {
        _destination = destination;
        _logger = logger;
    }

    public void SendMessage(IMessage message)
    {
        _logger.Logging(message, nameof(message.Priority));
        if (message == null) throw new ArgumentNullException(nameof(message));
        if (_destination.User.Priority < message.Priority)
            _destination.SendMessage(message);
    }
}
