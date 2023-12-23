namespace Application.Exceptions;

public class WrongPasswordException : IOException
{
    public WrongPasswordException(string message)
        : base(message)
    {
    }

    public WrongPasswordException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public WrongPasswordException()
    {
    }
}