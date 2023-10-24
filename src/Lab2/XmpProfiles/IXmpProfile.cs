using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.XmpProfiles;

public interface IXmpProfile
{
    Timings Timing { get; }
    int Voltage { get; }
    int Frequency { get; }
}