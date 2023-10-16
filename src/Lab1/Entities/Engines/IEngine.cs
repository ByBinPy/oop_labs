namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public interface IEngine
{
    double Speed { get; }
    double LengthWay { get; }
    double Fuel { get; }
    double Time { get; }
    void Move(double range);
    double Consumption();
    bool IsValidRange(double range);
}