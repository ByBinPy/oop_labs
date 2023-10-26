using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public class IntelFabric : BiosFabric
{
    public override IBios Create(string version)
    {
        var compatibleCpus = new Collection<Cpu> { /* add cpu */ };
        return new Intel(version, compatibleCpus);
    }
}