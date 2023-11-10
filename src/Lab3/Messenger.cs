using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Messenger
{
    private const string Title = "Messanger";
    private readonly List<IMessage> _messages = new List<IMessage>();

    public void AcceptMessage(IMessage message)
    {
        if (message is
            {
                Head: not null,
                Body: not null
            })
            _messages.Add(message);
    }

    public void ShowMessages()
    {
        Console.WriteLine(Title);
        foreach (IMessage i in _messages)
            Console.WriteLine(i.Head + "\n" + i.Body + "\n");
    }
}