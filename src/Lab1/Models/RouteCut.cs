using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class RouteCut
{
    private const double BaseLenCut = 200;
    public RouteCut(IEnvironment environment)
    {
        Environment = environment;
        Len = BaseLenCut;
    }

    public RouteCut(IEnvironment environment, int len)
    : this(environment)
    {
        Len = len;
    }

    public double Len { get; init; }
    public IEnvironment? Environment { get; init; }
}