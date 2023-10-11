using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Asteroid : IObstacle
{
    public bool IsValidEnvironment(IEnvironment environment)
    {
        return true;
    }
}
