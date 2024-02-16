using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class Display
{
    public Display(IDriver displayDriver)
    {
        DisplayDriver = displayDriver;
    }

    public IDriver DisplayDriver { get; }

    public void WriteMessage(IMessage message)
    {
        DisplayDriver.Write(message.Head + "\n" + message.Body + "\n");
    }
}