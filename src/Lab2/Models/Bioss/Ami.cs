using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public class Ami : IBios
{
    private const string DefaultVersion = "1.0";
    private readonly List<Cpu> _compatibleCpu;
    public Ami()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        _compatibleCpu = new List<Cpu>();
    }

    public Ami(string version, IList<Cpu> compatibleCpus)
        : this()
    {
        Version = version;
        _compatibleCpu = (List<Cpu>)compatibleCpus;
    }

    public string Type { get; }
    public string Version { get; }
}