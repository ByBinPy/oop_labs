namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Meteor : IObstacle
{
    private const int DefaultDamage = 1;

    public Meteor()
    {
        Damage = DefaultDamage;
    }

    public Meteor(int damage)
    {
        Damage = damage;
    }

    public int Damage { get; init; }
}