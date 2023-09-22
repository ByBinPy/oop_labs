using System;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public abstract class Deflector
{
    // null constant - show consist of Photonic diflector
    protected const PhotonicDeflector? Disable = null;
    protected const int Hp = 1;
    private const int DeathPoint = 0;
    protected virtual int DamageAsteroids { get; set; }
    protected virtual int DamageMeteorites { get; set; }
    protected virtual int DamageCosmoWhales { get; set; }
    protected virtual PhotonicDeflector? InstalledPhotonicDeflector { get; set; }
    protected virtual int HitPoints { get; set; }

    public virtual bool ExistencePhotonicDeflector()
    {
        return InstalledPhotonicDeflector?.IsAlive() ?? false;
    }

    public virtual bool IsAlive()
    {
        return HitPoints > DeathPoint;
    }

    public virtual void Damage(Obstacles obstacle)
    {
        if (!IsAlive())
            throw new FormatException("Try damage unfunctional deflector");
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
                if (InstalledPhotonicDeflector?.IsAlive() ?? false)
                {
                    InstalledPhotonicDeflector.Damage(obstacle);
                }
                else
                {
                    throw new AggregateException("Crew is died");
                }

                break;
            }

            case Obstacles.CosmoWhales:
            {
                HitPoints = DamageCosmoWhales;
                break;
            }

            default:
                throw new ArgumentException("Undefined Obstacles");
        }
    }
}