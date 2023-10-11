using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IDeflector
{
    double HealthPoints { get; }
    PhotonicDeflector? InstalledPhotonicDeflector { get; }
    double DamageAsteroid { get; }
    double DamageMeteor { get; }
    double DamageCosmoWhale { get; }
    double DamageAntimaterFlare { get; }
    Message GetDamage(IObstacle obstacle, out double damage);
    bool IsAlive();

    Message Damage(IObstacle obstacle);
}