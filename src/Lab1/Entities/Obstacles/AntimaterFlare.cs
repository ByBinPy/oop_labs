namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class AntimaterFlare : IObstacle
{
    private const double DefaultDamage = 1;
    public AntimaterFlare()
    {
        Damage = DefaultDamage;
    }

    public double Damage { get; private init; }
}