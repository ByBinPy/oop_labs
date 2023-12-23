using Port.Ports;
using Ports;

namespace Application;

public class BaseCommand : ICommand
{
    public BaseCommand()
    { }
    public Task ExecuteAsync()
    {
        throw new MissingMemberException();
    }
}