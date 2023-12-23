namespace Application.Exceptions;

public class NullRepoException : IOException
{
    public NullRepoException(string message)
        : base(message)
    {
    }

    public NullRepoException()
    {
    }

    public NullRepoException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}