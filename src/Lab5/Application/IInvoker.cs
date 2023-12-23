using Port.Ports;

namespace Application;

public interface IInvoker
{
    void SetCommand(ICommand command);
    Task ExecuteAsync();
}