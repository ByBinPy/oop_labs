using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
public class PulseEngineC : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 15;
    private const double DefaultLengthWay = 0;
    private const double StartFuel = 0;
    private const double CfSpeed = 3;
    private const double StartConsumption = 300.4;

    public double Speed { get; private set; } = FirstSpeed * CfSpeed;
    public double LengthWay { get; private set; } = DefaultLengthWay;
    public double Fuel { get; private set; } = StartFuel;
    public double Time { get; private set; }

    public void Move(double range)
    {
        if (IsValidRange(range))
        {
            LengthWay += range;
            Time += Math.Log(range);
            Speed = range * CfSpeed;
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