namespace Ports;

public interface ICommand
{
    Task ExecuteAsync();
}