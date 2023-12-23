using Port.Ports;

namespace Application.Chains;

public class BaseCommand : ICommand
{
    public BaseCommand()
    { }
    public Task ExecuteAsync()
    {
        throw new MissingMemberException();
    }
}