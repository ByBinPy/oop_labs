using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class ProxyUserDestination : ISender
{
    private const string IncorrectValue = "Incorrect value";
    private readonly UserDestination _destination;

    public ProxyUserDestination(UserDestination destination)
    {
        _destination = destination;
    }

    public void SendMessage(IMessage message)
    {
        Logging(message, nameof(message.Priority));
        if (message == null) throw new ArgumentNullException(nameof(message));
        if (_destination.User.Priority < message.Priority)
            _destination.SendMessage(message);
    }

    private static void Logging(IMessage message, string action)
    {
        if (message is
            {
                Head: not null,
                Body: not null,
            })
            Console.WriteLine(nameof(UserDestination) + " " + action);
        Console.WriteLine(nameof(UserDestination) + " " + action + " " + IncorrectValue + " " + nameof(Nullable));
    }
}
