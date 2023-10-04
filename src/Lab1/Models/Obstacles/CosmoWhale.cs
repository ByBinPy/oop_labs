namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class CosmoWhale : IObstacle
{
    private const int DefaultCount = 1;
    public CosmoWhale()
    {
        CountObstacles = DefaultCount;
    }

    public int CountObstacles { get; private init; }
}