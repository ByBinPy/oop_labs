namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class RedDriver : IDriver
{
    private Driver _driver;

    public RedDriver(Driver driver)
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

    public void RedText()
    {
        _driver.ChangeColorText(new Color(211, 13, 18));
    }
}