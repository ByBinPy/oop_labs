using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public sealed class PhotonicDeflector : IDeflector
{
    private const int DeathPoint = 0;

    public PhotonicDeflector(int damageAntimaterFlare)
    {
        HitPoints = 3 * damageAntimaterFlare;
    }

    public int HitPoints { get; private set; }

    public bool IsAlive()
    {
        return HitPoints > DeathPoint;
    }

    public Message Damage(IObstacle obstacle)
    {
        if (obstacle != null) HitPoints -= obstacle.Damage;
        else

            return new Message(IDeflector.NullObstacleMessage);

        if (!IsAlive())

            return new Message(IDeflector.UnfunctionalMessage);

        return new Message();
    }
}