using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.XmpProfiles;

public class Xmp : IXmpProfile
{
    public Xmp(Timings timing, int voltage, int frequency)
    {
        Timing = timing;
        Voltage = voltage;
        Frequency = frequency;
    }

    public Timings Timing { get; }
    public int Voltage { get; }
    public int Frequency { get; }
}