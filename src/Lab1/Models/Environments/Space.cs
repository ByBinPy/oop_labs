using System;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;

public class Space : IEnvironment
{
   public Space()
   {
      Description = "Space";
   }

   public Space(Collection<Obstacles>? environmentObstacles)
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
            throw new ArgumentException("Antimater flares does not add to simple space");
         }

         case Obstacles.CosmoWhales:
         {
            throw new ArgumentException("Cosmo whales does not add to simple space");
         }

         default:
         {
            throw new ArgumentException("Unexpected obstacle");
         }
      }
   }
}