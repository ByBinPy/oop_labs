using System;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class NeutrinoPerticleNebula : IEnvironment
{
    public NeutrinoPerticleNebula(Collection<Obstacles>? environmentObstacles)
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
                throw new ArgumentException("Antimater flares does not add to neutrino perticle nebula");
            }

            case Obstacles.CosmoWhales:
            {
                EnvironmentObstacles?.Add(item);
                break;
            }

            default:
            {
                throw new ArgumentException("Unexpected obstacle");
            }
        }
    }
}