namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

public class UefiFabric : BiosFabric
{
    public override IBios Create(string version)
    {
        return new Uefi(version);
    }
}