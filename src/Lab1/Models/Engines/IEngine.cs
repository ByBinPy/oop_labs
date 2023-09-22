namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public interface IEngine
{
    double Speed { get; }

    double Consumption();
}