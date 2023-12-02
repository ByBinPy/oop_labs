namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class DisconnectCommand : ICommand
{
    public void Execute()
    {
        FileSystem.ChangePath(string.Empty);
    }
}