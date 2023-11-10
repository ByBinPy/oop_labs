namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public interface IDriver
{
    void ChangeColorText(Color color);
    void Write(string text);
    void Clear();
}