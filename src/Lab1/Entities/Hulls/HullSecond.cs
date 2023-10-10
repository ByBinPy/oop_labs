using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class HullSecond : IHull
{
    private const double DefaultHealth = 100;
    private const double DeathPoints = 0;
    private const double DamageCf = 27;

    public HullSecond()
    {
        HealthPoints = DefaultHealth;
    }

    public HullSecond(IDeflector deflector)
        : this()
    {
        InstalledDiflector = deflector;
    }

    public double HealthPoints { get; private set; }
    public IDeflector? InstalledDiflector { get; private set; }

    public bool IsAlive()
    {
        return HealthPoints > DeathPoints;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (obstacle == null) return new Message(Message.NullObstacleMessage);

        var deflectorMessage = new Message();
        if (InstalledDiflector?.IsAlive() ?? false)
        {
            deflectorMessage = InstalledDiflector.Damage(obstacle);
        }
        else
        {
            if (obstacle is AntimaterFlare)

                return new Message(Message.DiedMessage);

            HealthPoints -= obstacle.Damage * DamageCf;
        }

        return !IsAlive() ? new Message(Message.CrashMessage) : deflectorMessage;
    }
}