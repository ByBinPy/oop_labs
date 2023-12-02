namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class Invoker : IInvoker
{
    private ICommand? _command;

    public void SetCommand(ICommand? command)
    {
        _command?.Execute();

        _command = command;
    }

    public void Execute()
    {
        _command?.Execute();
    }
}