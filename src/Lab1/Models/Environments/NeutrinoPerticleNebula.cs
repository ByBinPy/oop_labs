using System;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class NeutrinoPerticleNebula : IEnvironment
{
    public NeutrinoPerticleNebula()
    {
        Description = "NeutrinoPerticleNebula";
    }

    public NeutrinoPerticleNebula(Collection<Obstacles>? environmentObstacles)
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
                throw new ArgumentException("Antimater flares does not add to neutrino perticle nebula");
            }

            case Obstacles.CosmoWhale:
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