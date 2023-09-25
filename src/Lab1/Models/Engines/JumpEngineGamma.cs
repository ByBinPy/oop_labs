namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

public class JumpEngineGamma : IEngine
{
    private const double FirstSpeed = 1.0;
    private const double CfConsumption = 1.3;
    private const double StartConsumption = 10.4;
    private const double MaxRange = 500.6;

    public JumpEngineGamma()
    {
        Speed = FirstSpeed;
        Range = MaxRange;
    }

    public double Range { get; }
    public double Speed { get; private set; }

    public double Consumption()
    {
        return ((Speed * Speed) * CfConsumption) + StartConsumption;
    }
}