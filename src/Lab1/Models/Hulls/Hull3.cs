using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class Hull3 : IHull
{
    private const int Hp = IHull.Hp;
    public Hull3()
    {
        DamageAsteroids = 5 * Hp;
        DamageMeteorites = 20 * Hp;
        DamageCosmoWhales = 100 * Hp;
        HitPoints = 100 * Hp;
        InstalledDiflector = IHull.Disable;
    }

    public Hull3(IDeflector deflector)
        : this()
    {
        InstalledDiflector = deflector;
    }

    public int DamageAsteroids { get; set; }
    public int DamageMeteorites { get; set; }
    public int DamageCosmoWhales { get; set; }
    public int HitPoints { get; set; }
    public IDeflector? InstalledDiflector { get; set; }
    public bool IsAlive()
    {
        return HitPoints > IHull.DeathPoints;
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