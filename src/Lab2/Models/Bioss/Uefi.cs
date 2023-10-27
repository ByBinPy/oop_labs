using Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class Uefi : IBios
{
    private const string DefaultVersion = "1.0";
    private readonly BiosCpuRepo<Uefi> _compatibleCpus;
    public Uefi()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        _compatibleCpus = BiosRepoContext.Uefi;
    }

    public Uefi(string version)
        : this()
    {
        Version = version;
    }

    public string Type { get; }
    public string Version { get; }
}