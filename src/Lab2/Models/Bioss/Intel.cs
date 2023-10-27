using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class Intel : IBios
{
    private const string DefaultVersion = "1.0";
    private readonly BiosCpuRepo<Intel> _compatibleCpus;
    public Intel()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        _compatibleCpus = BiosRepoContext.Intel;
    }

    public Intel(string version)
        : this()
    {
        Version = version;
    }

    public BiosCpuRepo<Intel> CompatibleCpus => _compatibleCpus;
    public string Type { get; }
    public string Version { get; }
}