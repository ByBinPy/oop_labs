using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DeflectorClass1
{
    private const int Death = 0;
    private const int DamageAsteroids = 50;
    private const int DamageMeteorites = 100;
    private int _health = 100;

    public bool IsAlive()
    {
        return _health > Death;
    }

    public void Damage(Obstacles obstacle)
    {
        switch (obstacle)
        {
            case Obstacles.Asteroids:
            {
                _health -= DamageAsteroids;
                break;
            }

            case Obstacles.Meteorites:
            {
                _health -= DamageMeteorites;
                break;
            }

            case Obstacles.AntimaterFlares:
            {
                _health = Death;
                break;
            }

            case Obstacles.CosmoWhales:
            {
                _health = Death;
                break;
            }

            default:
                throw new ArgumentException("Undefinded Obstacles");
        }
    }
}