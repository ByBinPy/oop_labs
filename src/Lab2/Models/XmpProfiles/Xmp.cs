using System;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.XmpProfiles;

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
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (IXmpProfile)obj;

        return Timing == other.Timing &&
               Voltage == other.Voltage &&
               Frequency == other.Frequency;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Timing, Voltage, Frequency);
    }
}