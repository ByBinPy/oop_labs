using Port.Ports;

namespace Application;

public class Invoker : IInvoker
{
    private ICommand _command;

    public Invoker(ICommand command)
    {
        _command = command;
    }

    public void SetCommand(AdminLogin command)
    {
        _command = command;
    }

    public async Task ExecuteAsync()
    {
        await _command.ExecuteAsync().ConfigureAwait(false);
    }
}