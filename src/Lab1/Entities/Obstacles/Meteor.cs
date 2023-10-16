namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Meteor : IObstacle
{
    private const double DefaultDamage = 10;
    public double Damage { get; } = DefaultDamage;
}