namespace Application;

public interface IInvoker
{
    void SetCommand(AdminLogin command);
    Task ExecuteAsync();
}