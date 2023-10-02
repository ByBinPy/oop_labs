namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class CosmoWhale : IObstacle
{
    private const int DefaultDamage = 1;

    public CosmoWhale()
    {
        Damage = DefaultDamage;
    }

    public CosmoWhale(int damage)
    {
        Damage = damage;
    }

    public int Damage { get; init; }
}