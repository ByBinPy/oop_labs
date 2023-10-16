using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class PulseEngineE : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double DefaultLengthWay = 0;
    private const double StartFuel = 0;
    private const double CfConsumption = 25;
    private const double StartConsumption = 200.5;

    public double Speed { get; private set; } = FirstSpeed;
    public double LengthWay { get; private set; } = DefaultLengthWay;
    public double Fuel { get; private set; } = StartFuel;
    public double Time { get; private set; }

    public void Move(double range)
    {
        if (IsValidRange(range))
        {
            LengthWay += range;
            Speed = Math.Exp(range);
            Time += Math.Log(range);
        }
    }

    public double Consumption()
    {
        return (CfConsumption * LengthWay) + StartConsumption;
    }

    public bool IsValidRange(double range)
    {
        return range > 0;
    }
}