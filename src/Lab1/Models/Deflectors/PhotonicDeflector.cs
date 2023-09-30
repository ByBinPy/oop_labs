using System;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public class PhotonicDeflector
{
    private const int Death = 0;
    private const int DamageAntimaterFlares = 34;
    private int _health = 100;
    public bool IsAlive()
    {
        return _health >= Death;
    }

    // Blocking only AntimatedFlares
    public void Damage(Obstacles obstacle)
    {
        switch (obstacle)
        {
            case Obstacles.Asteroids:
            {
                throw new ArgumentOutOfRangeException(nameof(obstacle), "Damage cannot save from Asteroids");
            }

            case Obstacles.Meteorites:
            {
                throw new ArgumentOutOfRangeException(nameof(obstacle), "Damage cannot save from Meteorites");
            }

            case Obstacles.AntimaterFlares:
            {
                _health -= DamageAntimaterFlares;
                break;
            }

            case Obstacles.CosmoWhales:
            {
                throw new ArgumentOutOfRangeException(nameof(obstacle), "Damage cannot save from CosmoWhales");
            }

            default:
                throw new ArgumentOutOfRangeException(nameof(obstacle), "Undefined Obstacles");
        }
    }
}