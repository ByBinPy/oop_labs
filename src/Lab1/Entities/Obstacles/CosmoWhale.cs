namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class CosmoWhale : IObstacle
{
    private const double DefaultDamage = 31.5;
    public CosmoWhale()
    {
        Damage = DefaultDamage;
    }

    public double Damage { get; private init; }
}