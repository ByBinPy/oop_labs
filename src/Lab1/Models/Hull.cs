using System;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public abstract class Hull
{
    protected const int Hp = 1;
    protected const int DeathPoints = 0;
    protected const Deflector? Disable = null;
    protected virtual int DamageAsteroids { get; set; }
    protected virtual int DamageMeteorites { get; set; }
    protected virtual int DamageCosmoWhales { get; set; }
    protected virtual int HitPoints { get; set; }
    protected virtual Deflector? IntalledDiflector { get; set; }

    public virtual bool IsAlive()
    {
        return HitPoints > DeathPoints;
    }

    public virtual void Damage(Obstacles obstacle)
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