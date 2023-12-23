using Ports;

namespace CLI;

public interface IInvoker
{
    void SetCommand(ICommand command);
    Task ExecuteAsync();
}