using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class UserMessage : IMessage
{
    public UserMessage(DefaultMessage message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));
        Head = message.Head;
        Body = message.Body;
        Priority = message.Priority;
        Status = false;
    }

    public string Head { get; }
    public string Body { get; }
    public int Priority { get; }
    public bool Status { get; private set; }
}