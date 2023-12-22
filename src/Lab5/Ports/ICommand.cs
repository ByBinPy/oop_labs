using CLI;

namespace Ports;

public interface ICommand
{
    Task ExecuteAsync(Context context);
}