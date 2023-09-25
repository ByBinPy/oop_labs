using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineOmega : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 1.3;
    private const double StartConsumption = 10.4;
    private const double MaxRange = 1000.0;
    public JumpEngineOmega()
    {
        Speed = FirstSpeed;
        Range = MaxRange;
    }

    public double Range { get; }
    public double Speed { get; }
    public double Consumption()
    {
        return ((CfConsumption * Speed) * Math.Log2(CfConsumption * Speed)) + StartConsumption;
    }
}