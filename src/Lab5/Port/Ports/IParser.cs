namespace Port.Ports;

public interface IParser
{
    Task ParseAsync(Context context);
}