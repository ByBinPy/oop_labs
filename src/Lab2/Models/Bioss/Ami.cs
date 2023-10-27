using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class Ami : IBios
{
    private const string DefaultVersion = "1.0";
    private readonly BiosCpuRepo<Ami> _compatibleCpus;
    public Ami()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        _compatibleCpus = BiosRepoContext.Ami;
    }

    public Ami(string version)
        : this()
    {
        Version = version;
    }

    public string Type { get; }
    public string Version { get; }
}