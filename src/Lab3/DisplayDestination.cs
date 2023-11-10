namespace Itmo.ObjectOrientedProgramming.Lab3;

public class DisplayDestination : IDestination
{
    private Display _display;

    public DisplayDestination(Display display)
    {
        _display = display;
    }

    public void SendMessage(IMessage message)
    {
        if (message != null)
            _display.WriteMessage(message);
    }
}