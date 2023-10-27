namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class IntelFabric : BiosFabric
{
    public override IBios Create(string version)
    {
        return new Intel(version);
    }
}