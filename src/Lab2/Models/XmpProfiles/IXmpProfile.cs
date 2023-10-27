using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.XmpProfiles;

public interface IXmpProfile
{
    Timings Timing { get; }
    int Voltage { get; }
    int Frequency { get; }
    bool Equals(object obj);
}