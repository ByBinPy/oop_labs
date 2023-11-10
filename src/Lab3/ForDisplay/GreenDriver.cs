namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class GreenDriver : IDriver
{
    private Driver _driver;

    public GreenDriver(Driver driver)
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

    public void GreenText()
    {
        _driver.ChangeColorText(new Color(0, 224, 20));
    }
}