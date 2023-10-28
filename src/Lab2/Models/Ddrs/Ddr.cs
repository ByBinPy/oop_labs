using System;
using System.Collections.ObjectModel;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Models.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;

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
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (Ddr)obj;

        return QtyMemory == other.QtyMemory &&
               Jedec == other.Jedec &&
               DefaultVoltage == other.DefaultVoltage &&
               XmpProfiles.SequenceEqual(other.XmpProfiles) &&
               FormFactor == other.FormFactor &&
               Standard == other.Standard &&
               Power == other.Power;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(QtyMemory, Jedec, DefaultVoltage, XmpProfiles, FormFactor, Standard, Power);
    }
}