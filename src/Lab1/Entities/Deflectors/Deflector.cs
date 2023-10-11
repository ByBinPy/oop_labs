using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public abstract class Deflector : IDeflector
{
    public abstract double HealthPoints { get; protected set; }
    public abstract PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public abstract double DamageAsteroid { get; }
    public abstract double DamageMeteor { get; }
    public abstract double DamageCosmoWhale { get; }
    public abstract double DamageAntimaterFlare { get; }

    public Message GetDamage(IObstacle obstacle, out double damage)
    {
        switch (obstacle)
        {
            case Asteroid:
            {
                damage = DamageAsteroid;
                break;
            }

            case Meteor:
            {
                damage = DamageMeteor;
                break;
            }

            case AntimaterFlare:
            {
                if (InstalledPhotonicDeflector != null)
                {
                    damage = 0;
                    return InstalledPhotonicDeflector.Damage(obstacle);
                }
                else
                {
                    damage = 0;
                    return new Message(Message.DiedMessage);
                }
            }

            case CosmoWhale:
            {
                damage = DamageCosmoWhale;
                break;
            }

            default:
            {
                damage = 0;
                return new Message(Message.InvalidTypeMessage);
            }
        }

        return new Message();
    }

    public abstract bool IsAlive();

    public virtual Message Damage(IObstacle obstacle)
    {
        if (GetDamage(obstacle, out double damage).Text != Message.DefaultMessage)

            return GetDamage(obstacle, out double _);

        HealthPoints -= damage;

        return IsAlive() ? new Message() : new Message(Message.UnfunctionalMessage);
    }
}
