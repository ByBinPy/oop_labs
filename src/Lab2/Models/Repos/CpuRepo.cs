using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class CpuRepo
{
    private readonly List<Cpu> _cpus;
    public CpuRepo()
    {
        _cpus = new List<Cpu>
        {
            new CpuBuilder().WithCoreFrequency(3.1).WithQtyCore(4).WithSocket(new Socket("AM4"))
                .WithDdrStandard(new DdrStandard("DDR4")).WithQtyRamSlots(2).WithRamFrequency(2667)
                .WithGraphicCore(false).WithTdp(65).WithPower(70).Build(),

            new CpuBuilder().WithCoreFrequency(4.4).WithQtyCore(6).WithSocket(new Socket("LGA 1200"))
                .WithDdrStandard(new DdrStandard("DDR4")).WithQtyRamSlots(2).WithRamFrequency(3202)
                .WithGraphicCore(false).WithTdp(65).WithPower(75).Build(),

            new CpuBuilder().WithCoreFrequency(4).WithQtyCore(4).WithSocket(new Socket("AM3"))
                .WithDdrStandard(new DdrStandard("DDR3")).WithQtyRamSlots(2).WithRamFrequency(1866)
                .WithGraphicCore(false).WithTdp(95).WithPower(110).Build(),

            new CpuBuilder().WithCoreFrequency(3.3).WithQtyCore(2).WithSocket(new Socket("LGA 1151"))
                .WithDdrStandard(new DdrStandard("DDR3L")).WithQtyRamSlots(2).WithRamFrequency(2133)
                .WithGraphicCore(true).WithTdp(54).WithPower(65).Build(),

            new CpuBuilder().WithCoreFrequency(4.2).WithQtyCore(6).WithSocket(new Socket("AM4"))
                .WithDdrStandard(new DdrStandard("DDR4")).WithQtyRamSlots(2).WithRamFrequency(3200)
                .WithGraphicCore(true).WithTdp(65).WithPower(73).Build(),

            new CpuBuilder().WithCoreFrequency(5.6).WithQtyCore(12).WithSocket(new Socket("AM5"))
                .WithDdrStandard(new DdrStandard("DDR5")).WithQtyRamSlots(2).WithRamFrequency(5200)
                .WithGraphicCore(true).WithTdp(170).WithPower(200).Build(),

            new CpuBuilder().WithCoreFrequency(4.8).WithQtyCore(18).WithSocket(new Socket("LGA 2066"))
                .WithDdrStandard(new DdrStandard("DDR5")).WithQtyRamSlots(4).WithRamFrequency(5500)
                .WithGraphicCore(false).WithTdp(165).WithPower(180).Build(),

            new CpuBuilder().WithCoreFrequency(4.9).WithQtyCore(10).WithSocket(new Socket("LGA 1700"))
                .WithDdrStandard(new DdrStandard("DDR4")).WithQtyRamSlots(4).WithRamFrequency(3570)
                .WithGraphicCore(false).WithTdp(150).WithPower(157).Build(),

            new CpuBuilder().WithCoreFrequency(4.3).WithQtyCore(6).WithSocket(new Socket("LGA 1200"))
                .WithDdrStandard(new DdrStandard("DDR4")).WithQtyRamSlots(2).WithRamFrequency(2666)
                .WithGraphicCore(true).WithTdp(65).WithPower(74).Build(),

            new CpuBuilder().WithCoreFrequency(3.6).WithQtyCore(4).WithSocket(new Socket("LGA 1151"))
                .WithDdrStandard(new DdrStandard("DDR3")).WithQtyRamSlots(2).WithRamFrequency(2400)
                .WithGraphicCore(true).WithTdp(65).WithPower(74).Build(),

            new CpuBuilder().WithCoreFrequency(1.9).WithQtyCore(2).WithSocket(new Socket("LGA 1150"))
                .WithDdrStandard(new DdrStandard("DDR2")).WithQtyRamSlots(2).WithRamFrequency(1320)
                .WithGraphicCore(false).WithTdp(105).WithPower(114).Build(),

            new CpuBuilder().WithCoreFrequency(1000).WithQtyCore(4).WithSocket(new Socket("AM3"))
                .WithDdrStandard(new DdrStandard("DDR2")).WithQtyRamSlots(2).WithRamFrequency(1267)
                .WithGraphicCore(false).WithTdp(85).WithPower(100).Build(),
        };
    }

    public CpuRepo(IList<Cpu> cpus)
    {
        _cpus = new List<Cpu>(cpus);
    }

    public CpuRepo Add(Cpu cpu)
    {
        if (!RepoValidator.IsValidCpu(cpu))
            return new CpuRepo();

        _cpus.Add(cpu);

        return this;
    }

    public bool Update(Cpu cpu, Cpu newCpu)
    {
        if (_cpus.IndexOf(cpu) == -1)
            return false;

        _cpus[_cpus.IndexOf(cpu)] = newCpu;

        return true;
    }

    public bool Delete(Cpu cpu)
    {
        return _cpus.Remove(cpu);
    }

    public IList<Cpu>? FindAll(Predicate<Cpu> predicate) => _cpus.FindAll(predicate);
}