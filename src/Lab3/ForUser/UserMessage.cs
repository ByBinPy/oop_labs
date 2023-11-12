using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class UserMessage : IMessage
{
    public UserMessage(IMessage message)
    {
        Head = message.Head;
        Body = message.Body;
        Priority = message.Priority;
        Status = false;
    }

    public string Head { get; }

    public string Body { get; }

    public uint Priority { get; }

    public bool Status { get; private set; }

    public bool ChangeStatus()
    {
        if (Status) return false;

        Status = true;
        return true;
    }
}