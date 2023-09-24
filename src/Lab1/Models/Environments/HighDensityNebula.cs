using System;
using System.Collections.ObjectModel;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class HighDensityNebula : IEnvironment
{
    public HighDensityNebula(Collection<Obstacles>? environmentObstacles)
    {
        if (environmentObstacles == null) return;

        foreach (Obstacles i in environmentObstacles)
        {
            EnvironmentObstacles?.Add(i);
        }
    }

    public Collection<Obstacles>? EnvironmentObstacles { get; }

    public void Add(Obstacles item)
    {
        switch (item)
        {
            case Obstacles.Asteroids:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.Meteorites:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.AntimaterFlares:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.CosmoWhales:
            {
                throw new ArgumentException("Cosmo whales does not add to HighDensityNebula");
            }

            default:
            {
                throw new ArgumentException("Unexpected obstacle");
            }
        }
    }
}