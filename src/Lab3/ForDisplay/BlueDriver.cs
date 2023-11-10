namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class BlueDriver : IDriver
{
    private Driver _driver;

    public BlueDriver(Driver driver)
    {
        _driver = driver;
    }

    public void ChangeColorText(Color color)
    {
        _driver.ChangeColorText(color);
    }

    public void Write(string text)
    {
        _driver.Write(text);
    }

    public void Clear()
    {
        _driver.Clear();
    }

    public void BlueText()
    {
        _driver.ChangeColorText(new Color(25, 206, 240));
    }
}