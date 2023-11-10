namespace Itmo.ObjectOrientedProgramming.Lab3;

public class MessengerDestination : IDestination
{
    private Messenger _messenger;

    public MessengerDestination(Messenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMessage(IMessage message)
    {
        if (message != null)
            _messenger.AcceptMessage(message);
    }
}