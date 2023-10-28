namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Hdds;

public interface IHddBuilder
{
    IHddBuilder WithCapacity(int capacity);
    IHddBuilder WithSpeedRotation(int speedRotation);
    IHddBuilder WithPower(int power);
    Hdd Build();
}