using Ports;

namespace CLI;

public interface IInvoker
{
    void SetCommand(ICommand? command);
    void Execute();
}