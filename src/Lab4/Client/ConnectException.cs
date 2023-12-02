using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Client;

public class ConnectException : Exception
{
    public ConnectException()
    {
    }

    public ConnectException(string message)
        : base(message)
    {
    }

    public ConnectException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}