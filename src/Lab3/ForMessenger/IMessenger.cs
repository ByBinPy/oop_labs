using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForMessenger;

public interface IMessenger
{
    void ShowMessages();
    void AcceptMessage(IMessage message);
}