namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineAlpha : IEngine
{
    private const double FirstSpeed = 100.0;
    private const double CfConsumption = 1.3;
    private const double StartConsumption = 10.4;
    private const double MaxRange = 200.5;

    public JumpEngineAlpha()
    {
        Speed = FirstSpeed;
        Range = MaxRange;
    }

    public double Range { get; }
    public double Speed { get; }

    public double Consumption()
    {
        return (CfConsumption * Speed) + StartConsumption;
    }
}