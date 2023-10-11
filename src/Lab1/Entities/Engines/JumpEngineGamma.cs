using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineGamma : IEngine
{
    private const double FirstSpeed = 1000.0;
    private const double CfConsumption = 1.3;
    private const double StartConsumption = 10.4;
    private const double MaxRange = 500.6;
    private double _range;

    public double Range
    {
        get => _range;
        set
        {
            if (IsValidRange(value))
            {
                _range += value;
            }
            else
            {
                throw new ArgumentException("Invalid data in property");
            }
        }
    }

    public double Speed { get; } = FirstSpeed;

    public double Consumption()
    {
        return (CfConsumption * Range) + StartConsumption;
    }

    public bool IsValidRange(double range)
    {
        return range is > 0 and < MaxRange;
    }
}