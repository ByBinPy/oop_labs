using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Ddrs;

public class Ddr
{
    public Ddr(
        int qtyMemory,
        Jedec jedec,
        int defaultVoltage,
        ReadOnlyCollection<IXmpProfile> xmpProfiles,
        string formFactor,
        DdrStandard standard,
        int power)
    {
        QtyMemory = qtyMemory;
        Jedec = jedec;
        DefaultVoltage = defaultVoltage;
        XmpProfiles = xmpProfiles;
        FormFactor = formFactor;
        Standard = standard;
        Power = power;
    }

    public int QtyMemory { get; }
    public Jedec Jedec { get; }
    public int DefaultVoltage { get; }
    public ReadOnlyCollection<IXmpProfile> XmpProfiles { get; }
    public string FormFactor { get; }
    public DdrStandard Standard { get; }
    public int Power { get; }
}