using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IDeflector
{
    double HealthPoints { get; }
    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public bool IsAlive();

    public Message Damage(IObstacle obstacle);
}