using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class PulseEngineE : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 26.6;
    private const double StartConsumption = 200.5;
    private double _speed;
    public PulseEngineE()
    {
        Speed = FirstSpeed;
    }

    public double Speed
    {
        get => _speed;
        private set => _speed = Math.Exp(value);
    }

    public double Consumption()
    {
        return (CfConsumption * Speed) + StartConsumption;
    }
}