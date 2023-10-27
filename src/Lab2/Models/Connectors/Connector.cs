namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Connectors;

public class Connector
{
    public Connector(string version)
    {
        Version = version;
    }

    public string Version { get; }
}