using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public interface ILogger
{
    void Logging(IMessage message, string action);
}