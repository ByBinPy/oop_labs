using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class Hull3 : IHull
{
    private const int Hp = IHull.Hp;
    public Hull3()
    {
        DamageAsteroids = 5 * Hp;
        DamageMeteorites = 20 * Hp;
        DamageCosmoWhales = 100 * Hp;
        HitPoints = 100 * Hp;
        IntalledDiflector = IHull.Disable;
    }

    public Hull3(IDeflector deflector)
        : this()
    {
        IntalledDiflector = deflector;
    }

    public int DamageAsteroids { get; set; }
    public int DamageMeteorites { get; set; }
    public int DamageCosmoWhales { get; set; }
    public int HitPoints { get; set; }
    public IDeflector? IntalledDiflector { get; set; }
    public bool IsAlive()
    {
        return HitPoints > IHull.DeathPoints;
    }

    public void Damage(Obstacles obstacle)
    {
        {
            if (!IsAlive())
                throw new FormatException("Try damage unfunctional hull");
            if (IntalledDiflector?.IsAlive() ?? false)
            {
                IntalledDiflector.Damage(obstacle);
                return;
            }

            switch (obstacle)
            {
                case Obstacles.Asteroids:
                {
                    HitPoints -= DamageAsteroids;
                    break;
                }

                case Obstacles.Meteorites:
                {
                    HitPoints -= DamageMeteorites;
                    break;
                }

                case Obstacles.AntimaterFlares:
                {
                    throw new AggregateException("Crew has been died");
                }

                case Obstacles.CosmoWhales:
                {
                    throw new AggregateException("Ship has been broken");
                }

                default:
                    throw new ArgumentException("Undefined Obstacles");
            }
        }
    }
}