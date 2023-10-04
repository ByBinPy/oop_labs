using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class Hull2 : IHull
{
    private const int Hp = IHull.Hp;

    public Hull2()
    {
        DamageAsteroids = 20 * Hp;
        DamageMeteorites = 50 * Hp;
        DamageCosmoWhales = 100 * Hp;
        HitPoints = 100 * Hp;
        InstalledDiflector = IHull.Disable;
    }

    public Hull2(IDeflector deflector)
        : this()
    {
        InstalledDiflector = deflector;
    }

    public int DamageAsteroids { get; private set; }
    public int DamageMeteorites { get; private set; }
    public int DamageCosmoWhales { get; private set; }
    public int HitPoints { get; private set; }
    public IDeflector? InstalledDiflector { get; private set; }

    public bool IsAlive()
    {
        return HitPoints > DeathPoints;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (InstalledDiflector?.IsAlive() ?? false)

            return InstalledDiflector.Damage(obstacle);

        if (obstacle == null)

            return new Message(Message.NullObstacleMessage);

        switch (obstacle)
        {
            case Asteroid:
            {
                HitPoints -= DamageAsteroids;
                break;
            }

            case Meteor:
            {
                HitPoints -= DamageMeteorites;
                break;
            }

            case AntimaterFlare:
            {
                return new Message(Message.DiedMessage);
            }

            case CosmoWhale:
            {
                return new Message(Message.CrashMessage);
            }

            default:
                return new Message(Message.UnknownTypeMessage);
        }

        return new Message();
    }
}