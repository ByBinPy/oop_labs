namespace Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;

public class WiFiStandard
{
    public WiFiStandard(string version)
    {
        Version = version;
    }

    public string Version { get; }
}