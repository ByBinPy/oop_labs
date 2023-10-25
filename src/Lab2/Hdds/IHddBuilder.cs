namespace Itmo.ObjectOrientedProgramming.Lab2.Hdds;

public interface IHddBuilder
{
    IHddBuilder WithCapacity(int capacity);
    IHddBuilder WithSpeedRotation(int speedRotation);
    IHddBuilder WithPower(int power);
}