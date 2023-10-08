namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Meteor : IObstacle
{
    private const double DefaultDamage = 3.4;
    public Meteor()
    {
        Damage = DefaultDamage;
    }

    public double Damage { get; private init; }
}