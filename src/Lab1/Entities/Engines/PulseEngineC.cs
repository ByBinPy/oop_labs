namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class PulseEngineC : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 1.5;
    private const double StartConsumption = 300.4;
    public PulseEngineC()
    {
        Speed = FirstSpeed;
    }

    public PulseEngineC(int speed)
    {
        Speed = speed;
    }

    public double Speed { get; set; }

    public double Range { get; }
    public double Consumption()
    {
        return (CfConsumption * Speed) + StartConsumption;
    }
}