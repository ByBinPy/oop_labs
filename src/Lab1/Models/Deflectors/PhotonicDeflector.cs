using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public sealed class PhotonicDeflector : IDeflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int CountMeteor = 0;
    private const int CountAsteroid = 0;
    private const int CountAntimaterFlare = 3;
    public PhotonicDeflector()
    {
        InstalledPhotonicDeflector = Disable;
        (DamageMeteor, DamageAsteroid, HitPoints) = (CountAsteroid, CountMeteor, CountAntimaterFlare);
    }

    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public int HitPoints { get; private set; }
    public int DamageCosmoWhale { get; private init; }
    public int DamageMeteor { get; }
    public int DamageAsteroid { get; }

    public bool IsAlive()
    {
        return HitPoints > DeathPoint;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (obstacle != null)
        {
            if (obstacle is AntimaterFlare)
                HitPoints--;
        }
        else
        {
            return new Message(Message.NullObstacleMessage);
        }

        if (!IsAlive())
        {
            return new Message(Message.DiedMessage);
        }

        return new Message(Message.NullObstacleMessage);
    }
}