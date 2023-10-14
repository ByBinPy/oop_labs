using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class NeutrinoPerticleNebula : IEnvironment
{
    public NeutrinoPerticleNebula()
    {
        EnvironmentObstacles = new ReadOnlyCollection<IObstacle>(new Collection<IObstacle>());
    }

    public NeutrinoPerticleNebula(int countCosmoWhale)
    {
        EnvironmentObstacles = new ReadOnlyCollection<IObstacle>(CreateCollection(new CosmoWhale(), countCosmoWhale));
    }

    public ReadOnlyCollection<IObstacle> EnvironmentObstacles { get; }
    protected static Collection<IObstacle> CreateCollection(IObstacle obstacle, int count)
    {
        var outCollection = new Collection<IObstacle>();
        for (int i = 0; i < count; i++)
        {
            outCollection.Add(obstacle);
        }

        return outCollection;
    }
}