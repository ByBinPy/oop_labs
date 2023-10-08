using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public sealed class PhotonicDeflector : IDeflector, IDamager
{
    private const int DeathPoint = 0;
    private const double DefaultHealth = 3;
    public PhotonicDeflector()
    {
        HealthPoints = DefaultHealth;
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
            if (obstacle is AntimaterFlare)
                HealthPoints -= obstacle.Damage;
        }
        else
        {
            return new Message(Message.NullObstacleMessage);
        }

        return !IsAlive() ? new Message(Message.DiedMessage) : new Message(Message.NullObstacleMessage);
    }
}