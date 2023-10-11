using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class PulseEngineC : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 1.5;
    private const double CfSpeed = 3;
    private const double StartConsumption = 300.4;
    private double _range = 100;
    private double _speed = FirstSpeed;

    public double Speed { get; private set; }
    public double Range
    {
        get => _range;
        set
        {
            // range validation (speed proportional to range)
            if (IsValidRange(value))
            {
                _range += value;
                _speed = (value * CfSpeed) + FirstSpeed;
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