using Port.Ports;

namespace Application.Chains.Commands;

public class BaseCommand : ICommand
{
    public BaseCommand()
    { }
    public Task ExecuteAsync()
    {
        throw new MissingMemberException();
    }
}