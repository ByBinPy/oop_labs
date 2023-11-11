using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForMessenger;

public class ProxyMessengerDestination : IDestination
{
    private const string IncorrectValue = "Incorrect value";
    private readonly MessengerDestination _messengerDestination;
    private readonly ILogger _logger;

    public ProxyMessengerDestination(MessengerDestination destination)
    {
        _logger = new Logger();
        _messengerDestination = destination;
    }

    public ProxyMessengerDestination(MessengerDestination destination, ILogger logger)
    {
        _messengerDestination = destination;
        _logger = logger;
    }

    public void Logging(IMessage message, string action)
    {
        if (message is
            {
                Head: not null,
                Body: not null
            })
            Console.WriteLine(nameof(MessengerDestination) + " " + action);
        Console.WriteLine(nameof(UserDestination) + " " + action + " " + IncorrectValue + " " + nameof(Nullable));
    }

    public void SendMessage(IMessage message)
    {
        Logging(message, nameof(MessengerDestination));
        _messengerDestination.SendMessage(message);
    }
}