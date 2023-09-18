using System;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class TemplateDeflector
{
    protected const int Death = 0;
    protected const int InitialHitPoints = 100;
    protected static void Damage(Obstacles obstacle, ref int health, int damageAsteroids, int damageMeteorites, int damageAntimaterFlares, int damageCosmoWhales, PhotonicDeflector? thisPhotonicDeflector)
    {
        switch (obstacle)
        {
            case Obstacles.Asteroids:
            {
                health -= damageAsteroids;
                break;
            }

            case Obstacles.Meteorites:
            {
                health -= damageMeteorites;
                break;
            }

            case Obstacles.AntimaterFlares:
            {
                if (thisPhotonicDeflector?.IsAlive() ?? false)
                {
                    thisPhotonicDeflector.Damage(obstacle);
                }
                else
                {
                    health -= damageAntimaterFlares;
                }

                break;
            }

            case Obstacles.CosmoWhales:
            {
                health = damageCosmoWhales;
                break;
            }

            default:
                throw new ArgumentException("Undefined Obstacles");
        }
    }
}