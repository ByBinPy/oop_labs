namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Asteroid : IObstacle
{
    private const int DefaultCount = 1;
    public Asteroid()
    {
        CountObstacles = DefaultCount;
    }

    public int CountObstacles { get; private init; }
}