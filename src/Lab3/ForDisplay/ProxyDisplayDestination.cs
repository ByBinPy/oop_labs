using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class ProxyDisplayDestination : IDestination
{
    private const string IncorrectValue = "Incorrect value";
    private readonly DisplayDestination _displayDestination;
    private readonly ILogger _logger;

    public ProxyDisplayDestination(DisplayDestination destination)
    {
        _logger = new Logger();
        _displayDestination = destination;
    }

    public ProxyDisplayDestination(DisplayDestination destination, ILogger logger)
    {
        _displayDestination = destination;
        _logger = logger;
    }

    public void SendMessage(IMessage message)
    {
        Logging(message, nameof(SendMessage));
        _displayDestination.SendMessage(message);
    }

    public void Logging(IMessage message, string action)
    {
        if (message is
            {
                Head: not null,
                Body: not null,
            })
            Console.WriteLine(nameof(DisplayDestination) + " " + action + "\n" + message.Head + "\n" + message.Body + "\n");

        Console.WriteLine(nameof(DisplayDestination) + " " + action + "\n" + IncorrectValue + " " + nameof(Nullable));
    }
}