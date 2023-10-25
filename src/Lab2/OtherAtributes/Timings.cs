using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

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
}