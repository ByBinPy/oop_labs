using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class ProxiUserDestination : IDestination
{
    private const string IncorrectValue = "Incorrect value";
    private readonly UserDestination _destination;

    public ProxiUserDestination(UserDestination destination)
    {
        _destination = destination;
    }

    public static void Logging(IMessage message, string action)
    {
        if (message is
            {
                Head: not null,
                Body: not null,
            })
            Console.WriteLine(action + "\n" + message.Head + "\n" + message.Body + "\n");
        Console.WriteLine(action + "\n" + IncorrectValue + " " + nameof(Nullable));
    }

    public void SendMessage(IMessage message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));
        if (_destination.User.Priority < message.Priority)
            _destination.SendMessage(message);
        Logging(message, nameof(message.Priority));
    }
}
