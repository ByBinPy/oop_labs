using Itmo.ObjectOrientedProgramming.Lab2.Bioss;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class AmiFabric : BiosFabric
{
    public override IBios Create(string version)
    {
        return new Ami(version);
    }
}