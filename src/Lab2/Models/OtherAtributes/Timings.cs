using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;

public class Timings
{
    private const int DefaultTiming = 0;
    private Collection<int> _timings;
    public Timings(
        int firstTiming,
        int secondTiming = DefaultTiming,
        int thirdTiming = DefaultTiming,
        int fourthTiming = DefaultTiming)
    {
        _timings = new Collection<int> { firstTiming, secondTiming, thirdTiming, fourthTiming };
    }

    public int GetTiming(int serialNumber = DefaultTiming)
    {
        return _timings[serialNumber];
    }

    public bool EditTiming(int serialNumber, int value)
    {
        if (value <= 0)

            return false;

        _timings[serialNumber] = value;

        return true;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (Timings)obj;

        return _timings.SequenceEqual(other._timings);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_timings);
    }
}