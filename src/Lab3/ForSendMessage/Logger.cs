using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Logger : ILogger
{
    private const string IncorrectValue = "Incorrect value";
    public void Logging(IMessage message, string action)
    {
        if (message is
            {
                Head: not null,
                Body: not null,
            })
        {
            Console.WriteLine(nameof(UserDestination) + " " + action);
            return;
        }

        Console.WriteLine(nameof(UserDestination) + " " + action + " " + IncorrectValue + " " + nameof(Nullable));
    }
}