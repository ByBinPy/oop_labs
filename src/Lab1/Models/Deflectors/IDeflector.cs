using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IDeflector
{
    // null constant Disable - show consist of Photonic diflector;
    const string UnfunctionalMessage = "Is not functional";
    const string DiedMessage = "Crew is died";
    const string NullObstacleMessage = "Null obstacle";
    int HitPoints { get; }

    public bool IsAlive();

    public Message Damage(IObstacle obstacle);
}