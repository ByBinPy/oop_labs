namespace Itmo.ObjectOrientedProgramming.Lab3;

public class MessengerDestination : ISender
{
    private readonly Messenger _messenger;

    public MessengerDestination(Messenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMessage(IMessage message)
    {
        _messenger.AcceptMessage(message);
    }
}