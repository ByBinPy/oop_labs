namespace Application.Exceptions;

public class IncorrectAmount : IOException
{
    public IncorrectAmount(string message)
        : base(message)
    {
    }

    public IncorrectAmount()
    {
    }

    public IncorrectAmount(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}