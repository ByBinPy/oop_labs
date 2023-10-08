using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

// 1 c = 10
// 2 c = 1.55
// 3 c = 0.37;
public sealed class DeflectorClass1 : IDeflector, IDamager
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double DamageCf = 100;
    public DeflectorClass1()
    {
        InstalledPhotonicDeflector = Disable;
        HealthPoints = DefaultHealth;
    }

    public DeflectorClass1(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    public double HealthPoints { get; private set; }

    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
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

            HealthPoints -= obstacle.Damage * DamageCf;

            return IsAlive() ? new Message() : new Message(Message.UnfunctionalMessage);
        }

        return new Message(Message.NullObstacleMessage);
    }
}