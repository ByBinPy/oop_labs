using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Messenger
{
    private const string Title = "Messanger";
    private readonly List<DefaultMessage> _messages = new List<DefaultMessage>();

    public void AddMessage(DefaultMessage message)
    {
        _messages.Add(message);
    }

    public void ShowMessages()
    {
        Console.WriteLine(Title);
        foreach (DefaultMessage i in _messages)
            Console.WriteLine(i.Head + "\n" + i.Body + "\n");
    }
}