using System;
using System.Collections.ObjectModel;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class HighDensityNebula : IEnvironment
{
    public HighDensityNebula()
    {
        Description = "HighDensityNebula";
    }

    public HighDensityNebula(Collection<Obstacles>? environmentObstacles)
    : this()
    {
        if (environmentObstacles == null) return;

        foreach (Obstacles i in environmentObstacles)
        {
            EnvironmentObstacles?.Add(i);
        }
    }

    public Collection<Obstacles>? EnvironmentObstacles { get; }
    public string Description { get; }

    public void Add(Obstacles item)
    {
        switch (item)
        {
            case Obstacles.Asteroid:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.Meteorite:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.AntimaterFlare:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            case Obstacles.CosmoWhale:
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