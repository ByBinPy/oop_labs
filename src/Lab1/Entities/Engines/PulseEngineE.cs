using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class PulseEngineE : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 26.6;
    private const double StartConsumption = 200.5;
    private double _speed;
    private double _range;

    public double Speed { get; private set; }

    public double Range
    {
        get => _range;
        set
        {
            // range validation (speed proportional to range)
            if (IsValidRange(value))
            {
                _range = value;
                _speed = Math.Exp(value) + FirstSpeed;
            }
            else
            {
                throw new ArgumentException("Invalid data in property");
            }
        }
    }

    public double Consumption()
    {
        return (CfConsumption * Range) + StartConsumption;
    }

    public bool IsValidRange(double range)
    {
        return range > 0;
    }
}