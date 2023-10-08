using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IHull
{
    double HealthPoints { get;  }
    IDeflector? InstalledDiflector { get;  }

    bool IsAlive();

    Message Damage(IObstacle obstacle);
}