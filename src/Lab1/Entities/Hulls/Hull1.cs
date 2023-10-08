using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class Hull1 : IHull, IDamager
{
    private const double DeathPoints = 0;
    private const double DefaultHealth = 100;
    private const double DamageCf = 110;
    public Hull1()
    {
        HealthPoints = DefaultHealth;
    }

    public Hull1(IDeflector deflector)
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
        if (InstalledDiflector?.IsAlive() ?? false)

            return InstalledDiflector.Damage(obstacle);

        if (obstacle == null) return new Message(Message.NullObstacleMessage);

        if (obstacle is AntimaterFlare)

            return new Message(Message.DiedMessage);

        HealthPoints -= obstacle.Damage * DamageCf;

        return !IsAlive() ? new Message(Message.CrashMessage) : new Message(Message.NullObstacleMessage);
    }
}