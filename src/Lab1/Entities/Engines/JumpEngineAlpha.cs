using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineAlpha : IEngine
{
    private const double FirstSpeed = 1000.0;
    private const double CfConsumption = 1.3;
    private const double StartConsumption = 10.4;
    private const double MaxRange = 200.5;
    private double _range = MaxRange;

    public double Range
    {
        get => _range;
        set
        {
            if (IsValidRange(value - _range))
            {
                _range += value;
            }
            else
            {
                throw new ArgumentException($"Invalid data in property {value}");
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
