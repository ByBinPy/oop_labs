namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnits;

public class PowerUnit
{
    public PowerUnit(int peakLoad)
    {
        PeakLoad = peakLoad;
    }

    public int PeakLoad { get; }
}