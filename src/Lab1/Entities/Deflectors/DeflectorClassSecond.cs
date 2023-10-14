using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClassSecond : IDeflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double AsteroidCoefficient = 2;
    private const double MeteorCoefficicient = 3.4;
    public DeflectorClassSecond()
    {
        InstalledPhotonicDeflector = Disable;
        HealthPoints = DefaultHealth;
        DamageCfAsteroid = AsteroidCoefficient;
        DamageCfMeteor = MeteorCoefficicient;
    }

    public DeflectorClassSecond(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    public double HealthPoints { get; private set; }
    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public double DamageCfAsteroid { get; }
    public double DamageCfMeteor { get; }

    public bool IsAlive()
    {
        return HealthPoints > DeathPoint;
    }

    public double GetCoefficientDamage(IObstacle obstacle)
    {
        if (obstacle == null)
            return 0;

        switch (obstacle)
        {
            case Asteroid:

                return DamageCfAsteroid;

            case Meteor:

                return DamageCfMeteor;

            default:
            {
                return 1;
            }
        }
    }

    public Message Damage(IObstacle obstacle)
    {
        if (obstacle == null)
            return new Message(" ");

        if (obstacle is AntimaterFlare && (InstalledPhotonicDeflector?.IsAlive() ?? false))

            return InstalledPhotonicDeflector.Damage(obstacle);

        if (obstacle is AntimaterFlare)

            return new Message(Message.DiedMessage);

        if (obstacle is CosmoWhale)
            return new Message(Message.CrashMessage);
        HealthPoints -= GetCoefficientDamage(obstacle) * obstacle.Damage;
        return IsAlive() ? new Message() : new Message(Message.UnfunctionalMessage);
    }
}