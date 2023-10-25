using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public class Ami : IBios
{
    private const string DefaultVersion = "1.0";
    public Ami()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        CompatibleCpus = new ReadOnlyCollection<Cpu>(new List<Cpu>());
    }

    public Ami(string version, IList<Cpu> compatibleCpus)
        : this()
    {
        Version = version;
        CompatibleCpus = new ReadOnlyCollection<Cpu>(compatibleCpus);
    }

    public string Type { get; }
    public string Version { get; }
    public ReadOnlyCollection<Cpu> CompatibleCpus { get; }
}