using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForTopic;

public interface ITopic
{
    string Name { get; }
    DestinationFilter Destination { get; }
    IMessage Message { get; }
}