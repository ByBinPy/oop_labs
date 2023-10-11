using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public interface IObstacle
{
    bool IsValidEnvironment(IEnvironment environment);
}