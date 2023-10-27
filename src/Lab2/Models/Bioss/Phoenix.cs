using Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class Phoenix : IBios
{
    private const string DefaultVersion = "1.0";
    private readonly BiosCpuRepo<Phoenix> _compatibleCpus;
    public Phoenix()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        _compatibleCpus = BiosRepoContext.Phoenix;
    }

    public Phoenix(string version)
        : this()
    {
        Version = version;
    }

    public string Type { get; }
    public string Version { get; }
}