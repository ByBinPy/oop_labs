using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClass1 : IDeflector
{
    private const int Hp = IDeflector.Hp;

    public DeflectorClass1()
    {
        DamageAsteroids = 50 * Hp;
        DamageMeteorites = 100 * Hp;
        DamageCosmoWhales = 100 * Hp;
        HitPoints = 100 * Hp;
        InstalledPhotonicDeflector = IDeflector.Disable;
    }

    public DeflectorClass1(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    public int DamageAsteroids { get; }
    public int DamageMeteorites { get;  }
    public int DamageCosmoWhales { get; }
    public PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public int HitPoints { get; private set; }

    public bool ExistencePhotonicDeflector()
    {
        return InstalledPhotonicDeflector?.IsAlive() ?? false;
    }

    public bool IsAlive()
    {
        return HitPoints > IDeflector.DeathPoint;
    }

    public void Damage(Obstacles obstacle)
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
                    throw new AggregateException("Crew has been died");
                }

                break;
            }

            case Obstacles.CosmoWhales:
            {
                HitPoints = DamageCosmoWhales;
                break;
            }

            default:
                throw new ArgumentOutOfRangeException(nameof(obstacle), "Undefinded obstacle in switch");
        }
    }
}