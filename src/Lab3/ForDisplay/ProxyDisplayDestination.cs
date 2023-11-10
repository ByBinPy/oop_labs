using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class ProxyDisplayDestination : ISender
{
    private const string IncorrectValue = "Incorrect value";
    private readonly DisplayDestination _displayDestination;
    public ProxyDisplayDestination(DisplayDestination displayDestination)
    {
        _displayDestination = displayDestination;
    }

    public void SendMessage(IMessage message)
    {
        Logging(nameof(SendMessage), message);
        _displayDestination.SendMessage(message);
    }

    private void Logging(string action, IMessage message)
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