namespace Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnits;

public class PowerUnit
{
    public PowerUnit(int peakLoad)
    {
        PeakLoad = peakLoad;
    }

    public int PeakLoad { get; }
}