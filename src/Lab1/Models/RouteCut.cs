using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class RouteCut
{
    private const double SmallLengthCut = 200;
    public RouteCut(IEnvironment environment)
    {
        Environment = environment;
        LengthWay = SmallLengthCut;
    }

    public RouteCut(IEnvironment environment, int length)
    : this(environment)
    {
        LengthWay = length;
    }

    public double LengthWay { get; }
    public IEnvironment? Environment { get; }
}