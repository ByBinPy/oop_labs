namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class PhoenixFabric : BiosFabric
{
    public override IBios Create(string version)
    {
        return new Phoenix(version);
    }
}