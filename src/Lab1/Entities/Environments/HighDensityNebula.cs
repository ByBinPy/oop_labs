using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class HighDensityNebula : Environment
{
    private readonly Collection<IObstacle> _environmentObstacles;

    public HighDensityNebula()
    {
        _environmentObstacles = new Collection<IObstacle>();
    }

    public HighDensityNebula(Collection<IObstacle>? environmentObstacles)
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