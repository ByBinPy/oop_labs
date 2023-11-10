namespace Itmo.ObjectOrientedProgramming.Lab3;

public interface ITopic : ISender
{
    string Name { get; }
    ISender Destination { get; }
    IMessage Message { get; }
}