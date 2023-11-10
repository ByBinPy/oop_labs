using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class ProxyGroupDestination : ISender
{
    private const string IncorrectValue = "Incorrect value";
    private readonly GroupDestination _groupDestination;

    public ProxyGroupDestination(GroupDestination groupDestination)
    {
        _groupDestination = groupDestination;
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
        Logging(nameof(GroupDestination), message);
        _groupDestination.SendMessage(message);
    }
}