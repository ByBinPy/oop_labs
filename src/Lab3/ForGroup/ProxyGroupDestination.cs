using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessenger;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForGroup;

public class ProxyGroupDestination : IDestination
{
    private const string IncorrectValue = "Incorrect value";
    private readonly GroupDestination _groupDestination;
    private readonly ILogger _logger;

    public ProxyGroupDestination(GroupDestination destination)
    {
        _logger = new Logger();
        _groupDestination = destination;
    }

    public ProxyGroupDestination(GroupDestination destination, ILogger logger)
    {
        _groupDestination = destination;
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
        Logging(message, nameof(GroupDestination));
        _groupDestination.SendMessage(message);
    }
}