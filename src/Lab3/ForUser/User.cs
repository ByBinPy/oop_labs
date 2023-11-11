using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForUser;

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

    public bool GetStatusMessage(string head)
    {
        foreach (UserMessage userMessage in _userMessages)
        {
            if (head == userMessage.Head)
                return userMessage.Status;
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

    public bool ChangeStatus(string head)
    {
        foreach (UserMessage message in _userMessages)
        {
            if (message.Head == head)
            {
               return message.ChangeStatus();
            }
        }

        return false;
    }
}