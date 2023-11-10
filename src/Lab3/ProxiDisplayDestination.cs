using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class ProxiDisplayDestination : IDestination
{
    private readonly DisplayDestination _displayDestination;

    public ProxiDisplayDestination(DisplayDestination displayDestination)
    {
        _displayDestination = displayDestination;
    }

    public void SendMessage(IMessage message)
    {
        Logging(message);
        if (message != null)
            _displayDestination.SendMessage(message);
    }

    private static void Logging(IMessage message)
    {
        if (message is
            {
                Head: not null,
                Body: not null
            })
            Console.WriteLine(message);
    }
}