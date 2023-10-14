namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class CosmoWhale : IObstacle
{
    private const double DefaultDamage = 100;
    public double Damage { get; } = DefaultDamage;
}