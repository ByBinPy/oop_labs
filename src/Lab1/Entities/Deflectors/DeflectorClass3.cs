using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClass3 : IDeflector, IDamager
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double DamageCf = 3.15;
    public DeflectorClass3()
    {
        InstalledPhotonicDeflector = Disable;
        HealthPoints = DefaultHealth;
    }

    public DeflectorClass3(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public double HealthPoints { get; private set; }

    public bool IsAlive()
    {
        return HealthPoints > DeathPoint;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (obstacle != null)
        {
            if (obstacle is AntimaterFlare && InstalledPhotonicDeflector != null)

                return InstalledPhotonicDeflector.Damage(obstacle);
            else if (InstalledPhotonicDeflector == null)

                return new Message(Message.DiedMessage);

            HealthPoints -= obstacle.Damage * DamageCf;

            return IsAlive() ? new Message() : new Message(Message.UnfunctionalMessage);
        }

        return new Message(Message.NullObstacleMessage);
    }
}