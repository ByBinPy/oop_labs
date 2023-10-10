using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClassSecond : IDeflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double DamageCf = 13;
    public DeflectorClassSecond()
    {
        InstalledPhotonicDeflector = Disable;
        HealthPoints = DefaultHealth;
    }

    public DeflectorClassSecond(PhotonicDeflector? photonicDeflector)
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

            if (obstacle is AntimaterFlare)

                return new Message(Message.DiedMessage);

            HealthPoints -= obstacle.Damage * DamageCf;

            return IsAlive() ? new Message() : new Message(Message.UnfunctionalMessage);
        }

        return new Message(Message.NullObstacleMessage);
    }
}