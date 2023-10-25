using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public interface IBios
{
    public string Type { get; }
    public string Version { get; }
    public ReadOnlyCollection<Cpu> CompatibleCpus { get; }
}