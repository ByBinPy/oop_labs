namespace Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

public class Jedec
{
    private const int DefaultTiming = 0;
    public Jedec(
        int frequency,
        int firstTiming,
        int secondTiming = DefaultTiming,
        int thirdTiming = DefaultTiming,
        int fourthTiming = DefaultTiming)
    {
        RamFrequency = frequency;
        Timings = new Timings(firstTiming, secondTiming, thirdTiming, fourthTiming);
    }

    public int RamFrequency { get; }
    private Timings Timings { get; }
    public int GetTiming(int serialNumber = DefaultTiming)
    {
        return Timings.GetTiming(serialNumber);
    }
}