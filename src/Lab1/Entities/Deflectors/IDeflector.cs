using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IDeflector
{
    double HealthPoints { get; }
    PhotonicDeflector? InstalledPhotonicDeflector { get; }
    double DamageCfAsteroid { get; }
    double DamageCfMeteor { get; }
    double GetCoefficientDamage(IObstacle obstacle);
    bool IsAlive();

    Message Damage(IObstacle obstacle);
}