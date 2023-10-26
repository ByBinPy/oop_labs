using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.XmpProfiles;

public class Xmp : IXmpProfile
{
    private const int DefaultFirstTiming = 20;
    public Xmp(int frequency)
    {
        Frequency = frequency;
        Timing = new Timings(DefaultFirstTiming);
    }

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