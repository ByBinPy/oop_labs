namespace Application.Exceptions;

public class InvalidInputException : IOException
{
    public InvalidInputException(string message)
        : base(message)
    {
    }

    public InvalidInputException()
    {
    }

    public InvalidInputException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}