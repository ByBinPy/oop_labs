namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public interface IEngine
{
    double Speed { get; }
    double Range { get; set; }
    double Consumption();
    bool IsValidRange(double range);
}