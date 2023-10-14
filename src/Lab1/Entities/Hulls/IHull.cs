using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IHull
{
    double HealthPoints { get; }
    IDeflector? InstalledDeflector { get; }
    double DamageCfAsteroid { get; }
    double DamageCfMeteor { get; }
    double GetCfDamage(IObstacle obstacle);
    bool IsAlive();

    Message Damage(IObstacle obstacle);
}