using System;
using Itmo.ObjectOrientedProgramming.Lab4.ForParser;

namespace Itmo.ObjectOrientedProgramming.Lab4.Client;

public static class ConsoleClient
{
    public static void ConnectToConsole()
    {
        string? consoleComands = Console.ReadLine();
        var parser = new Parser();
        while (true)
        {
            parser.Parse(new Context(consoleComands?.Split(" ") ?? new string[1]));
            consoleComands = Console.ReadLine();
            if (string.IsNullOrEmpty(consoleComands))
                return;
        }
    }
}