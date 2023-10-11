using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class NeutrinoPerticleNebula : Environment
{
    private readonly Collection<IObstacle> _environmentObstacles;
    public NeutrinoPerticleNebula()
    {
        _environmentObstacles = new Collection<IObstacle>();
    }

    public NeutrinoPerticleNebula(Collection<IObstacle>? environmentObstacles)
        : this()
    {
        if (environmentObstacles != null)
        {
            foreach (IObstacle i in environmentObstacles)
            {
                EnvironmentObstacles?.Add(i);
            }
        }
    }

    public override Collection<IObstacle> EnvironmentObstacles
    {
        get => _environmentObstacles;
    }
}