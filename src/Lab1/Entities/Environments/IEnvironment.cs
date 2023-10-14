using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public interface IEnvironment
{
    ReadOnlyCollection<IObstacle>? EnvironmentObstacles { get; }
}