namespace Itmo.ObjectOrientedProgramming.Lab4.Client;

public interface IDataShow
{
    void SetDisplay(IDataDisplay dataDisplay);

    void Show(string data);

    void DisplayWithMode(string mode);
}