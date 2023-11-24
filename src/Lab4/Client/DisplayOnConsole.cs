using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class DisplayOnConsole : IDataDisplay
{
    public void Display(string data)
    {
        Console.WriteLine(data);
    }
}