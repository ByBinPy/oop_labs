using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class UserMessage : IMessage
{
    public UserMessage(IMessage message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));
        Head = message.Head;
        Body = message.Body;
        Priority = message.Priority;
        Status = false;
    }

    public string Head { get; }

    public string Body { get; }

    public uint Priority { get; }

    public bool Status { get; private set; }

    public void ChangeStatus()
    {
        if (Status) throw new ArgumentException("Not valid change <status message is already viewed>");

        Status = true;
    }
}