namespace Port.Ports;

public interface ICommand
{
    Task ExecuteAsync();
}