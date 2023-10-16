using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public sealed class PhotonicDeflector : IDeflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 3;
    private const double AsteroidCoefficient = 0;
    private const double MeteorCoefficient = 0;
    public PhotonicDeflector()
    {
        InstalledPhotonicDeflector = Disable;
        HealthPoints = DefaultHealth;
        DamageCfAsteroid = AsteroidCoefficient;
        DamageCfMeteor = MeteorCoefficient;
    }

    public double HealthPoints { get; private set; }
    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public double DamageCfAsteroid { get; }
    public double DamageCfMeteor { get; }
    public double GetCoefficientDamage(IObstacle obstacle)
    {
        if (obstacle == null)
            return DeathPoint;

        return DamageCfMeteor;
    }

    public bool IsAlive()
    {
        return HealthPoints > DeathPoint;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (obstacle is AntimaterFlare)
            HealthPoints -= obstacle.Damage;
        return IsAlive() ? new Message() : new Message(Message.DiedMessage);
    }
}