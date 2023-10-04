using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class Hull1 : IHull
{
    private const int DeathPoints = 0;
    private const IDeflector? Disable = null;
    private const int CountMeteor = 1;
    private const int CountAsteroid = 1;
    public Hull1()
    {
        (DamageMeteors, DamageAsteroids, HitPoints, DamageCosmoWhales) = () 
    }

    public Hull1(IDeflector deflector)
        : this()
    {
        InstalledDiflector = deflector;
    }

    public int DamageAsteroids { get; private set; }
    public int DamageMeteors { get; private set; }
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
        {
            return new Message(Message.NullObstacleMessage);
        }

        switch (obstacle)
        {
            case Asteroid:
            {
                HitPoints -= DamageAsteroids;
                break;
            }

            case Meteor:
            {
                HitPoints -= DamageMeteors;
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