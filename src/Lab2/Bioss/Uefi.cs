using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public class Uefi : IBios
{
    private const string DefaultVersion = "1.0";
    public Uefi()
    {
        Type = nameof(Phoenix);
        Version = DefaultVersion;
        CompatibleCpus = new ReadOnlyCollection<Cpu>(new List<Cpu>());
    }

    public Uefi(string version)
        : this()
    {
        Version = version;
    }

    public string Type { get; }
    public string Version { get; }
    public ReadOnlyCollection<Cpu> CompatibleCpus { get; }
}