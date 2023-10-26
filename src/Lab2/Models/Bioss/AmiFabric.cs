using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public class AmiFabric : BiosFabric
{
    public override IBios Create(string version)
    {
        var compatibleCpus = new List<Cpu> { /* add cpu */ };
        return new Ami(version, compatibleCpus);
    }
}