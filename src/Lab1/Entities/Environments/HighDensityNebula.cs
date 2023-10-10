using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class HighDensityNebula : IEnvironment
{
    public HighDensityNebula()
    {
        EnvironmentObstacles = new Collection<IObstacle>();
    }

    public HighDensityNebula(Collection<IObstacle> environmentObstacles)
    : this()
    {
        if (environmentObstacles != null)
        {
            foreach (IObstacle i in environmentObstacles)
            {
                EnvironmentObstacles.Add(i);
            }
        }
    }

    public Collection<IObstacle> EnvironmentObstacles { get; }

    public Message Add(IObstacle? item)
    {
        if (item == null)

            return new Message(Message.NullObstacleMessage);
        if (item is CosmoWhale)

            return new Message(Message.InvalidTypeMessage);

        EnvironmentObstacles?.Add(item);

        return new Message();
    }

    public Message Add(IObstacle item, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (item == null)

                return new Message(Message.NullObstacleMessage);
            if (item is CosmoWhale)

                return new Message(Message.InvalidTypeMessage);

            EnvironmentObstacles?.Add(item);
        }

        return new Message();
    }
}