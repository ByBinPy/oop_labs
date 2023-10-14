namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Asteroid : IObstacle
{
    private const double DefaultDamage = 5;
    public double Damage { get; } = DefaultDamage;
}
