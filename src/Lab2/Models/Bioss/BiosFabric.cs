using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bioss;

public abstract class BiosFabric
{
    public abstract IBios Create(string version);
}