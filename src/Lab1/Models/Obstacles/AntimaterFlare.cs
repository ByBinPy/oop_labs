namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class AntimaterFlare : IObstacle
{
    private const int DefaultDamage = 1;

    public AntimaterFlare()
    {
        Damage = DefaultDamage;
    }

    public AntimaterFlare(int damage)
    {
        Damage = damage;
    }

    public int Damage { get; init; }
}