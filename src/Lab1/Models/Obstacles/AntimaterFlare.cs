namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class AntimaterFlare : IObstacle
{
    private const int DefaultCount = 1;
    public AntimaterFlare()
    {
        CountObstacles = DefaultCount;
    }

    public int CountObstacles { get; private init; }
}