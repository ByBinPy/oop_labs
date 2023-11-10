using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class DefaultTopic : ITopic
{
    public DefaultTopic(string name, IDestination destination, IMessage message)
    {
        Name = name;
        Destination = destination;
        Message = message ?? throw new ArgumentNullException(nameof(message));
    }

    public string Name { get; }
    public IDestination Destination { get; }
    public IMessage Message { get; }
}