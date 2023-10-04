using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IDeflector
{
    // null constant Disable - show consist of Photonic diflector;
    public int DamageCosmoWhale { get; }
    public int DamageMeteor { get; }
    public int DamageAsteroid { get; }
    int HitPoints { get; }

    public bool IsAlive();

    public Message Damage(IObstacle obstacle);
}