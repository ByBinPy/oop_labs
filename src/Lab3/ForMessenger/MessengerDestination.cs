using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForMessenger;

public class MessengerDestination : IDestination
{
    private readonly IMessenger _messenger;
    public MessengerDestination(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public IMessenger Messenger => _messenger;

    public void SendMessage(IMessage message)
    {
        _messenger.AcceptMessage(message);
    }
}