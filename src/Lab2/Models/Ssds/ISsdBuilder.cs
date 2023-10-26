using Itmo.ObjectOrientedProgramming.Lab2.Connectors;

namespace Itmo.ObjectOrientedProgramming.Lab2.Ssds;

public interface ISsdBuilder
{
    ISsdBuilder WithCapacity(int capacity);
    ISsdBuilder WithConnection(Connector connector);
    ISsdBuilder WithMaxSpeed(int maxSpeed);
    ISsdBuilder WithPower(int power);
    Ssd Build();
}