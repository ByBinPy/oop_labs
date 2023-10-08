using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class NeutrinoPerticleNebula : IEnvironment
{
    public NeutrinoPerticleNebula(Collection<IObstacle>? environmentObstacles)
    {
        if (environmentObstacles == null)
            EnvironmentObstacles = new Collection<IObstacle>();

        if (environmentObstacles != null)
        {
            foreach (IObstacle i in environmentObstacles)
            {
                EnvironmentObstacles?.Add(i);
            }
        }
    }

    public Collection<IObstacle>? EnvironmentObstacles { get; }

    public Message Add(IObstacle item)
    {
        if (item == null)

            return new Message(Message.NullObstacleMessage);
        if (item is AntimaterFlare)

            return new Message(Message.InvalidTypeMessage);

        EnvironmentObstacles?.Add(item);
        return new Message();
    }
}