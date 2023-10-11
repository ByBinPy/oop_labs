using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class CosmoWhale : IObstacle
{
    public bool IsValidEnvironment(IEnvironment environment)
    {
        return environment is NeutrinoPerticleNebula;
    }
}