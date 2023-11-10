using System;
using System.Collections.Generic;
namespace Itmo.ObjectOrientedProgramming.Lab3;

public class User
{
    private readonly List<UserMessage> _userMessages;
    public User(int id, int priority)
    {
        Id = id;
        Priority = priority;
        _userMessages = new List<UserMessage>();
    }

    public int Id { get; }
    public int Priority { get; }
    public bool AcceptMessage(IMessage message)
    {
        if (message is
            {
                Body: not null,
                Head: not null,
            })
        {
            _userMessages.Add(new UserMessage(message));
            return true;
        }

        return false;
    }

    public void ShowMessages()
    {
        foreach (UserMessage message in _userMessages)
        {
            Console.WriteLine(
                message.Head + "\n"
              + message.Body + "\n"
              + (message.Status ? "Viewed" : "Not viewed") + "\n");
        }
    }

    public void ChangeStatus(string head)
    {
        foreach (UserMessage message in _userMessages)
        {
            if (message.Head == head)
            {
                message.ChangeStatus();
                return;
            }
        }
    }
}