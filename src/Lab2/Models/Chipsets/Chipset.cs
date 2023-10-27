namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public class Chipset
{
    public Chipset(bool supportXmp, int ramFrequency)
    {
        SupportXmp = supportXmp;
        RamFrequency = ramFrequency;
    }

    public bool SupportXmp { get; }
    public int RamFrequency { get; }
}