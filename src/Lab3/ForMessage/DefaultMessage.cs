namespace Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

public class DefaultMessage : IMessage
{
    public DefaultMessage()
    {
        Head = string.Empty;
        Body = string.Empty;
        Priority = 0;
    }

    public DefaultMessage(string head, string body, uint priority)
    {
        Head = head;
        Body = body;
        Priority = priority;
    }

    public string Head { get; }
    public string Body { get; }
    public uint Priority { get; }
}