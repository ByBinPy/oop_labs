using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClass3 : IDeflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    public DeflectorClass3()
    {
        InstalledPhotonicDeflector = Disable;
    }

    public DeflectorClass3(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public int HitPoints { get; private set; }

    public bool ExistencePhotonicDeflector()
    {
        return InstalledPhotonicDeflector?.IsAlive() ?? false;
    }

    public bool IsAlive()
    {
        return HitPoints > DeathPoint;
    }

    public Message Damage(IObstacle obstacle)
    {
        if ((obstacle is AntimaterFlare) && ExistencePhotonicDeflector())
            InstalledPhotonicDeflector?.Damage(obstacle);
        else if (obstacle is AntimaterFlare)

            return new Message();

        if (obstacle != null) HitPoints -= obstacle.Damage;
        else

            return new Message(IDeflector.NullObstacleMessage);

        if (!IsAlive())

            return new Message(IDeflector.UnfunctionalMessage);

        return new Message();
    }
}