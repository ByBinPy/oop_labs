namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Hdds;

public class Hdd
{
    public Hdd(int capacity, int spedRotation, int power)
    {
        Capacity = capacity;
        SpedRotation = spedRotation;
        Power = power;
    }

    public int Capacity { get; }
    public int SpedRotation { get; }
    public int Power { get; }
}