namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Asteroid : IObstacle
{
    private const int DefaultDamage = 1;

    public Asteroid()
    {
        Damage = DefaultDamage;
    }

    public Asteroid(int damage)
    {
        Damage = damage;
    }

    public int Damage { get; init; }
}