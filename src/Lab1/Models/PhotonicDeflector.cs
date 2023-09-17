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

    public void Damage(Obstacles obstacle)
    {
        switch (obstacle)
        {
            case Obstacles.Asteroids:
            {
                throw new ArgumentException("Damage cannot save from Asteroids");
            }

            case Obstacles.Meteorites:
            {
                throw new ArgumentException("Damage cannot save from Meteorites");
            }

            case Obstacles.AntimaterFlares:
            {
                _health -= DamageAntimaterFlares;
                break;
            }

            case Obstacles.CosmoWhales:
            {
                throw new ArgumentException("Damage cannot save from CosmoWhales");
            }

            default:
                throw new ArgumentException("Undefined Obstacles");
        }
    }
}