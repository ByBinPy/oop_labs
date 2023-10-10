namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public record Message
{
    public const string DiedMessage = "Crew is died";
    public const string NullObstacleMessage = "Null obstacle";
    public const string NullRouteMessage = "Null route";
    public const string UnknownTypeMessage = "Unknown Type";
    public const string InvalidTypeMessage = "Invalid Type";
    public const string CrashMessage = "Ship was crashed";
    public const string UnfunctionalMessage = "Unfuctional element";
    public const string LackRangeMessage = "Lack of range";
    public const string DefaultMessage = "Success";
    public Message()
    {
        Text = DefaultMessage;
    }

    public Message(string text)
    {
        Text = text;
    }

    public string? Text { get; init; }
}