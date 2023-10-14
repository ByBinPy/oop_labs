using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class HighDensityNebula : IEnvironment
{
    public HighDensityNebula()
    {
        EnvironmentObstacles = new ReadOnlyCollection<IObstacle>(new Collection<IObstacle>());
    }

    public HighDensityNebula(int countAntimaterFlare)
    {
        EnvironmentObstacles =
            new ReadOnlyCollection<IObstacle>(CreateCollection(new AntimaterFlare(), countAntimaterFlare));
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