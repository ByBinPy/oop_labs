using Itmo.ObjectOrientedProgramming.Lab2.Connectors;

namespace Itmo.ObjectOrientedProgramming.Lab2.Ssds;
public class Ssd
{
   public Ssd(int capacity, Connector howConnection, int maxSpeed, int power)
   {
      Capacity = capacity;
      HowConnection = howConnection;
      MaxSpeed = maxSpeed;
      Power = power;
   }

   public Connector HowConnection { get; }
   public int Capacity { get; }
   public int MaxSpeed { get; }
   public int Power { get; }
}