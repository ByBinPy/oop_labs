using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public class Phoenix : IBios
{
    private const string DefaultVersion = "1.0";
    public Phoenix()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        CompatibleCpus = new ReadOnlyCollection<Cpu>(new List<Cpu>());
    }

    public Phoenix(string version, Collection<Cpu> compatibleCpu)
    : this()
    {
        Version = version;
        CompatibleCpus = new ReadOnlyCollection<Cpu>(compatibleCpu);
    }

    public string Type { get; }
    public string Version { get; }
    public ReadOnlyCollection<Cpu> CompatibleCpus { get; }
}