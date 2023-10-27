using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public class IntelFabric : BiosFabric
{
    public override IBios Create(string version)
    {
        return new Intel(version);
    }
}