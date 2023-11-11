using System;
using System.IO;
using Crayon;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class Driver : IDriver
{
    private Color _color = new Color(255, 255, 255);
    public static string FilePath { get; } = @"C:\LabaFile\Display\LabaFile";
    public string? Text { get; private set; }

    public void Clear()
    {
        // clearing file
        FileStream fileStream = File.Open(FilePath, FileMode.Open);
        fileStream.SetLength(0);
        fileStream.Close();
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
        File.WriteAllText(FilePath, Text);
    }
}