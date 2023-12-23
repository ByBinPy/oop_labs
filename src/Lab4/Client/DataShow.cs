using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class DataShow : IDataShow
{
    private IDataDisplay _dataDisplay = new DisplayOnConsole();

    public void SetDisplay(IDataDisplay dataDisplay)
    {
        _dataDisplay = dataDisplay;
    }

    public void Show(string data)
    {
        _dataDisplay.Display(data);
    }

    public void DisplayWithMode(string mode)
    {
        if (mode == "console")
        {
            SetDisplay(new DisplayOnConsole());
            return;
        }

        // etc
    }
}