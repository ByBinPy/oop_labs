using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class DestinationLogging : IDestination
{
    private readonly IDestination _destination;
    private readonly ILogger _logger = new Logger();

    public DestinationLogging(IDestination destination)
    {
        _destination = destination;
    }

    public DestinationLogging(IDestination destination, ILogger logger)
    {
        _destination = destination;
        _logger = logger;
    }

    public void SendMessage(IMessage message)
    {
        _logger.Logging(message, nameof(SendMessage));
        _destination.SendMessage(message);
    }
}