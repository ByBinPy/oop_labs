using System;
using Itmo.ObjectOrientedProgramming.Lab4.ForParser;

namespace Itmo.ObjectOrientedProgramming.Lab4.Client;

public static class ConsoleClient
{
    public static void ConnectToConsole()
    {
        string? consoleComands = Console.ReadLine();
        var parser = new Parser(new Invoker());
        while (true)
        {
            parser.Parse(new Context(consoleComands?.Split(" ") ?? new string[1]));
            consoleComands = Console.ReadLine();
            parser.Invoker.Execute();
            parser.Invoker.SetCommand(null);
            if (string.IsNullOrEmpty(consoleComands))
                return;
        }
    }
}