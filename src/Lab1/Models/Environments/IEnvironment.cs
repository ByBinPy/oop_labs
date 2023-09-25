using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public interface IEnvironment
{
    string Description { get; }
    Collection<Obstacles>? EnvironmentObstacles { get; }
    void Add(Obstacles item);
}