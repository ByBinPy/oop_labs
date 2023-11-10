namespace Itmo.ObjectOrientedProgramming.Lab3;

public interface ITopic
{
    string Name { get; }
    IDestination Destination { get; }
    IMessage Message { get; }
}