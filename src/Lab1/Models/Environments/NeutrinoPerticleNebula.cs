using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class NeutrinoPerticleNebula : IEnvironment
{
    public NeutrinoPerticleNebula(Collection<IObstacle>? environmentObstacles)
    {
        if (environmentObstacles == null) return;

        foreach (IObstacle i in environmentObstacles)
        {
            EnvironmentObstacles?.Add(i);
        }
    }

    public Collection<IObstacle>? EnvironmentObstacles { get; }

    public Message Add(IObstacle item)
    {
        switch (item)
        {
            case Obstacles.Asteroid:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.Meteor:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.AntimaterFlare:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.CosmoWhale:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            default:
            {
                return new Message(Message.UnknownTypeMessage);
            }
        }

        return new Message();
    }
}