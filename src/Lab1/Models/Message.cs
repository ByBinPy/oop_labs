namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public record Message
{
    private const string DefaultMessage = "Success";

    public Message()
    {
        Text = DefaultMessage;
    }

    public Message(string text)
    {
        Text = text;
    }

    public string? Text { get; initZ; }
}