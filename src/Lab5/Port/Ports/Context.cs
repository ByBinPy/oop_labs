namespace Port.Ports;

public class Context
{
    public Context(IReadOnlyCollection<string> input)
    {
        Input = input;
    }

    public IReadOnlyCollection<string> Input { get; }
}