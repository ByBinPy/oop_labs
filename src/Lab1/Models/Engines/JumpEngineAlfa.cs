namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineAlfa : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 1.3;
    private const double StartConsumption = 10.4;

    public JumpEngineAlfa()
    {
        Speed = FirstSpeed;
    }

    public double Speed { get; private set; }

    public double Consumption()
    {
        return (CfConsumption * Speed) + StartConsumption;
    }
}