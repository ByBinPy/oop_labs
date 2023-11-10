using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForDisplay;

public class Display
{
    public static string FilePath { get; } = @"C:\LabaFile\Display\LabaFile";
    public Driver DisplayDriver { get; } = new Driver();
    public bool WriteMessage(IMessage message)
    {
        if (message is
            {
                Head: not null,
                Body: not null,
                Priority: > 0,
            })
        {
            DisplayDriver.Write(message.Head + "\n" + message.Body + "\n");
            return true;
        }

        return false;
    }

    public void ShowMessage()
    {
        DisplayDriver.Clear();
        Console.WriteLine(DisplayDriver.Text);
        File.WriteAllText(FilePath, DisplayDriver.Text);
    }
}