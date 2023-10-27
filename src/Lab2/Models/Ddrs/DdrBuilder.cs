using System;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Models.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;

public class DdrBuilder : IDdrBuilder
{
    private int _qtyMemory;
    private Jedec? _jedec;
    private int _defaultVoltage;
    private ReadOnlyCollection<IXmpProfile>? _xmpProfiles;
    private string? _formFactor;
    private DdrStandard? _standard;
    private int _power;
    public DdrBuilder() { }

    public DdrBuilder(Ddr ddr)
    {
        if (ddr == null) return;
        _qtyMemory = ddr.QtyMemory;
        _jedec = ddr.Jedec;
        _defaultVoltage = ddr.DefaultVoltage;
        _xmpProfiles = ddr.XmpProfiles;
        _formFactor = ddr.FormFactor;
        _standard = ddr.Standard;
        _power = ddr.Power;
    }

    public IDdrBuilder WithQtyMemory(int qtyMemory)
    {
        _qtyMemory = qtyMemory;
        return this;
    }

    public IDdrBuilder WithJedec(Jedec jedec)
    {
        _jedec = jedec;
        return this;
    }

    public IDdrBuilder WithDefaultVoltage(int voltage)
    {
        _defaultVoltage = voltage;
        return this;
    }

    public IDdrBuilder WithFormFactors(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IDdrBuilder WithDdrStandard(DdrStandard ddrStandard)
    {
        _standard = ddrStandard;
        return this;
    }

    public IDdrBuilder WithXmpProfiles(Collection<IXmpProfile> xmpProfiles)
    {
        _xmpProfiles = new ReadOnlyCollection<IXmpProfile>(xmpProfiles);
        return this;
    }

    public IDdrBuilder Power(int power)
    {
        _power = power;
        return this;
    }

    public Ddr Build()
    {
        return new Ddr(
            _qtyMemory,
            _jedec ?? throw new ArgumentNullException(),
            _defaultVoltage,
            _xmpProfiles ?? throw new ArgumentNullException(),
            _formFactor ?? throw new ArgumentNullException(),
            _standard ?? throw new ArgumentNullException(),
            _power);
    }
}