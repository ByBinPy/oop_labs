using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineOmega : IEngine
{
    private const double FirstSpeed = 1000.0;
    private const double DefaultLengthWay = 0;
    private const double StartFuel = 0;
    private const double CfConsumption = 1.3;
    private const double StartConsumption = 10.4;
    private const double MaxRange = 1000.0;

    public double LengthWay { get; private set; } = DefaultLengthWay;
    public double Fuel { get; private set; } = StartFuel;
    public double Time { get; private set; }
    public double Speed { get; } = FirstSpeed;

    public void Move(double range)
    {
        if (IsValidRange(range))
        {
            LengthWay += range;
            Time += Math.Log(range);
        }
    }

    public double Consumption()
    {
        return (CfConsumption * LengthWay) + StartConsumption;
    }

    public bool IsValidRange(double range)
    {
        return range is > 0 and < MaxRange;
    }
}