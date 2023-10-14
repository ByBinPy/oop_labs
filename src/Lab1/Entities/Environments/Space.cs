using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class Space : IEnvironment
{
    public Space()
    {
        EnvironmentObstacles = new ReadOnlyCollection<IObstacle>(new Collection<IObstacle>());
    }

    public Space(int countAsteroids, int countMeteors)
    {
        EnvironmentObstacles = new ReadOnlyCollection<IObstacle>(AddMeteors(CreateCollection(new Asteroid(), countAsteroids), countMeteors));
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

    private static Collection<IObstacle> AddMeteors(Collection<IObstacle> obstacles, int countMeteors)
    {
        for (int i = 0; i < countMeteors; i++)
        {
            obstacles.Add(new Meteor());
        }

        return obstacles;
    }
}