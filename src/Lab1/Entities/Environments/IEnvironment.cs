using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public interface IEnvironment
{
    Collection<IObstacle>? EnvironmentObstacles { get; }
    Message Add(IObstacle item);
    Message Add(IObstacle item, int count);
}