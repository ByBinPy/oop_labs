namespace Itmo.ObjectOrientedProgramming.Lab2.Sockets;

public class Socket
{
    public Socket(string version)
    {
        Version = version;
    }

    public string Version { get; }
}