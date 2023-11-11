using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class DisplayDestination : IDestination
{
    private readonly Display _display;

    public DisplayDestination(Display display)
    {
        _display = display;
    }

    public Display Display => _display;
    public void SendMessage(IMessage message)
    {
        _display.WriteMessage(message);
    }
}