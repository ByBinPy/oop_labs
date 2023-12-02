namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public interface IInvoker
{
    void SetCommand(ICommand? command);
    void Execute();
}