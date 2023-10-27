using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Models.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class DdrRepo
{
    private readonly List<Ddr> _ddrs;
    public DdrRepo()
    {
        _ddrs = new List<Ddr>()
        {
            new DdrBuilder().WithDdrStandard(new DdrStandard("DDR3.0"))
                            .WithJedec(new Jedec(2600, 30))
                            .WithFormFactors("DIMM")
                            .WithQtyMemory(8)
                            .WithXmpProfiles(new Collection<IXmpProfile> { new Docp(new Timings(10, 10, 10, 10), 8, 3900) })
                            .WithDefaultVoltage(6)
                            .Power(25).Build(),
            new DdrBuilder().WithDdrStandard(new DdrStandard("DDR4"))
                            .WithJedec(new Jedec(3200, 21, 12, 12, 21))
                            .WithFormFactors("DIMM")
                            .WithQtyMemory(16)
                            .WithXmpProfiles(new Collection<IXmpProfile> { new Docp(new Timings(15), 6, 3200) })
                            .WithDefaultVoltage(4)
                            .Power(26).Build(),
            new DdrBuilder().WithDdrStandard(new DdrStandard("DDR3"))
                            .WithJedec(new Jedec(3000, 7, 10, 11, 12))
                            .WithFormFactors("SO-DIMM")
                            .WithQtyMemory(4)
                            .WithXmpProfiles(new Collection<IXmpProfile> { new Docp(new Timings(10, 14, 12, 6), 7, 4000) })
                            .WithDefaultVoltage(5)
                            .Power(20).Build(),
            new DdrBuilder().WithDdrStandard(new DdrStandard("DDR5"))
                            .WithJedec(new Jedec(4000, 5, 3, 4, 4))
                            .WithFormFactors("DIMM")
                            .WithQtyMemory(16)
                            .WithXmpProfiles(new Collection<IXmpProfile> { new Docp(new Timings(3, 4, 2, 5), 9, 4000) })
                            .WithDefaultVoltage(7)
                            .Power(30).Build(),
        };
    }

    public DdrRepo(IList<Ddr> dds)
    {
        _ddrs = new List<Ddr>(dds);
    }

    public DdrRepo Add(Ddr dd)
    {
        if (!RepoValidator.IsValidDdr(dd))
            return new DdrRepo();

        _ddrs.Add(dd);

        return this;
    }

    public bool Update(Ddr dd, Ddr newDdr)
    {
        if (_ddrs.IndexOf(dd) == -1)
            return false;

        _ddrs[_ddrs.IndexOf(dd)] = newDdr;

        return true;
    }

    public bool Delete(Ddr dd)
    {
        return _ddrs.Remove(dd);
    }

    public IList<Ddr>? FindAll(Predicate<Ddr> predicate) => _ddrs.FindAll(predicate);
}