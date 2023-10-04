using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClass2 : IDeflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int CountMeteor = 3;
    private const int CountAsteroid = 10;
    public DeflectorClass2()
    {
        InstalledPhotonicDeflector = Disable;
        (DamageMeteor, DamageAsteroid, HitPoints, DamageCosmoWhale) = (CountAsteroid, CountMeteor, CountAsteroid * CountMeteor, DamageCosmoWhale);
    }

    public DeflectorClass2(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public int HitPoints { get; private set; }
    public int DamageCosmoWhale { get; private init; }
    public int DamageMeteor { get; private init; }
    public int DamageAsteroid { get; private init; }

    public bool IsAlive()
    {
        return HitPoints > DeathPoint;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (obstacle == null)
            return new Message(Message.NullObstacleMessage);
        for (int i = 0; i < obstacle.CountObstacles; i++)
        {
            switch (obstacle)
            {
                case Asteroid:
                {
                    HitPoints -= obstacle.CountObstacles * DamageAsteroid;
                    break;
                }

                case Meteor:
                {
                    HitPoints -= obstacle.CountObstacles * DamageMeteor;
                    break;
                }

                case CosmoWhale:
                {
                    HitPoints -= obstacle.CountObstacles * DamageCosmoWhale;
                    break;
                }

                case AntimaterFlare:
                {
                    if (InstalledPhotonicDeflector?.IsAlive() ?? false)
                        return InstalledPhotonicDeflector.Damage(obstacle);

                    return new Message(Message.DiedMessage);
                }

                default:
                {
                    return new Message(Message.UnknownTypeMessage);
                }
            }

            if (!IsAlive())
                return new Message(Message.UnfunctionalMessage);
        }

        return new Message(Message.NullObstacleMessage);
    }
}