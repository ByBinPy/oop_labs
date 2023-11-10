using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForMessenger;

public class ProxyMessengerDestination : ISender
{
    private const string IncorrectValue = "Incorrect value";
    private readonly MessengerDestination _messengerDestination;

    public ProxyMessengerDestination(MessengerDestination messengerDestination)
    {
        _messengerDestination = messengerDestination;
    }

    public void Logging(string action, IMessage message)
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
        Logging(nameof(MessengerDestination), message);
        _messengerDestination.SendMessage(message);
    }
}