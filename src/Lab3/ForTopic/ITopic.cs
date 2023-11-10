using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForTopic;

public interface ITopic : ISender
{
    string Name { get; }
    ISender Destination { get; }
    IMessage Message { get; }
}