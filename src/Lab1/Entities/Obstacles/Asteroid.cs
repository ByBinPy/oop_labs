namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Asteroid : IObstacle
{
    private const double DefaultDamage = 0.8;
    public Asteroid()
    {
        Damage = DefaultDamage;
    }

    public double Damage { get; private init; }
}