using System;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class TemplateDeflector
{
    private const int Death = 0;
    protected TemplateDeflector(PhotonicDeflector thisPhotonicDeflector)
    {
        ThisPhotonicDeflector = thisPhotonicDeflector;
    }

    public int DamageAsteroids { get; protected set; }
    public int DamageMeteorites { get; protected set; }
    public int DamageAntimaterFlares { get; protected set; }
    public int DamageCosmoWhales { get; protected set; }
    public PhotonicDeflector ThisPhotonicDeflector { get; protected set; }
    public int Health { get; set; }

    protected bool IsAlive()
    {
        return Health > Death;
    }

    protected void Damage(Obstacles obstacle)
    {
        if (!IsAlive())
            return;
        switch (obstacle)
        {
            case Obstacles.Asteroids:
            {
                Health -= DamageAsteroids;
                break;
            }

            case Obstacles.Meteorites:
            {
                Health -= DamageMeteorites;
                break;
            }

            case Obstacles.AntimaterFlares:
            {
                if (ThisPhotonicDeflector.IsAlive())
                {
                    ThisPhotonicDeflector.Damage(obstacle);
                }
                else
                {
                    Health -= DamageAntimaterFlares;
                }

                break;
            }

            case Obstacles.CosmoWhales:
            {
                Health = DamageCosmoWhales;
                break;
            }

            default:
                throw new ArgumentException("Undefined Obstacles");
        }
    }
}