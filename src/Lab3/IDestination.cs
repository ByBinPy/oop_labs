namespace Itmo.ObjectOrientedProgramming.Lab3;

public interface IDestination
{
    bool AddMessage(DefaultMessage message);
    bool Logging(DefaultMessage message);
}