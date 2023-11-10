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
}