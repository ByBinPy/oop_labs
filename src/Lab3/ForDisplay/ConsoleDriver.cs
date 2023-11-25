using System;
using Crayon;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class ConsoleDriver : IDriver
{
    private Color _color = new Color(255, 255, 255);
    public string? Text { get; private set; }

    public void Clear()
    {
        Console.Clear();
    }

    public void ChangeColorText(Color color)
    {
        _color = color ?? throw new ArgumentNullException(nameof(color));
    }

    public void Write(string text)
    {
        Text = Output.Rgb(_color.R, _color.B, _color.G).Text(text);
        Clear();
        Console.WriteLine(Text);
    }
}