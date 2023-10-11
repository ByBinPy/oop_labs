using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public abstract class Environment : IEnvironment
{
    public abstract Collection<IObstacle> EnvironmentObstacles { get; }

    public Message Add(IObstacle? item)
    {
        if (item == null)

            return new Message(Message.NullObstacleMessage);

        if (item.IsValidEnvironment(this))
        {
            EnvironmentObstacles?.Add(item);
        }
        else
        {
            return new Message(Message.InvalidTypeMessage);
        }

        return new Message();
    }

    public Message Add(IObstacle? item, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (item == null)

                return new Message(Message.NullObstacleMessage);

            if (item.IsValidEnvironment(this))
            {
                EnvironmentObstacles?.Add(item);
            }
            else
            {
                return new Message(Message.InvalidTypeMessage);
            }
        }

        return new Message();
    }
}