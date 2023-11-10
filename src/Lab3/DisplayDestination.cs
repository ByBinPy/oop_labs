namespace Itmo.ObjectOrientedProgramming.Lab3;

public class DisplayDestination : ISender
{
    private Display _display;

    public DisplayDestination(Display display)
    {
        _display = display;
    }

    public void SendMessage(IMessage message)
    {
        _display.WriteMessage(message);
    }
}