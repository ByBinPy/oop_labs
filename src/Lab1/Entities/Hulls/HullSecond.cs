using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class HullSecond : IHull
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double AsteroidCoefficient = 4;
    private const double MeteorCoefficient = 5;
    public HullSecond()
    {
        InstalledDeflector = Disable;
        HealthPoints = DefaultHealth;
        DamageCfAsteroid = AsteroidCoefficient;
        DamageCfMeteor = MeteorCoefficient;
        DamageAntimaterFlare = DeathPoint;
    }

    public HullSecond(IDeflector deflector)
        : this()
    {
        InstalledDeflector = deflector;
    }

    public double HealthPoints { get; private set; }
    public IDeflector? InstalledDeflector { get; }
    public double DamageCfAsteroid { get; }
    public double DamageCfMeteor { get; }
    public double DamageAntimaterFlare { get; }

    public double GetCfDamage(IObstacle obstacle)
    {
        switch (obstacle)
        {
            case Asteroid:
            {
                return DamageCfAsteroid;
            }

            case Meteor:
            {
                return DamageCfMeteor;
            }

            default:
            {
                return 1;
            }
        }
    }

    public bool IsAlive()
    {
        return HealthPoints > DeathPoint;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (InstalledDeflector?.IsAlive() ?? false)

            return InstalledDeflector.Damage(obstacle);

        HealthPoints -= GetCfDamage(obstacle);

        return IsAlive() ? new Message() : new Message(Message.CrashMessage);
    }
}