using System;
using System.IO;
using Crayon;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Driver
{
    public string? Text { get; private set; }
    private Color Color { get;  set; } = new Color(255, 255, 255);
    public static void Clear()
    {
        // clearing file
        FileStream fileStream = File.Open(Display.FilePath, FileMode.Open);
        fileStream.SetLength(0);
        fileStream.Close();
        Console.Clear();
    }

    public void ChangeColorText(Color color)
    {
        Color = color ?? throw new ArgumentNullException(nameof(color));
    }

    public void Write(string text)
    {
        Text = Output.Rgb(Color.R, Color.B, Color.G).Text(text);
    }
}