namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;

public class Socket
{
    public Socket(string version)
    {
        Version = version;
    }

    public string Version { get; }
}