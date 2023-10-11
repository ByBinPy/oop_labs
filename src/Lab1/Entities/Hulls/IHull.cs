using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IHull
{
    double HealthPoints { get; }
    Deflector? InstalledDeflector { get; }
    double DamageAsteroid { get; }
    double DamageMeteor { get; }
    double DamageCosmoWhale { get; }
    Message GetDamage(IObstacle obstacle, out double damage);
    bool IsAlive();

    Message Damage(IObstacle obstacle);
}