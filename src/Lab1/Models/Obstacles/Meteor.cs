namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Meteor : IObstacle
{
    private const int DefaultCount = 1;
    public Meteor()
    {
        CountObstacles = DefaultCount;
    }

    public int CountObstacles { get; private init; }
}