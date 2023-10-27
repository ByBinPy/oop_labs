using System;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Hdds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.PcCases;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnits;
using Itmo.ObjectOrientedProgramming.Lab2.Ssds;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;

public class PcBuilder
{
    private MotherBoard? _motherBoard;
    private Cpu? _cpu;
    private Ddr? _ddr;
    private CpuCoolingSystem? _cpuCoolingSystem;
    private PcCase? _pcCase;
    private PowerUnit? _powerUnit;
    private Ssd? _ssd;
    private Hdd? _hdd;
    private VideoCard? _videoCard;
    private WiFiAdapter? _wiFiAdapter;
    public PcBuilder() { }

    public PcBuilder(Pc pc)
    {
        if (pc == null) return;
        _motherBoard = pc.MotherBoardPc;
        _cpu = pc.CpuPc;
        _ddr = pc.DdrPc;
        _cpuCoolingSystem = pc.CpuCoolingSystemPc;
        _pcCase = pc.PcCasePc;
        _powerUnit = pc.PowerUnitPc;
        _ssd = pc.SsdPc;
        _hdd = pc.HddPc;
        _videoCard = pc.VideoCardPc;
        _wiFiAdapter = pc.WiFiAdapterPc;
    }

    public PcBuilder WithCpu(Cpu cpu)
    {
        _cpu = cpu;
        return this;
    }

    public PcBuilder WithMotherBoard(MotherBoard motherBoard)
    {
        _motherBoard = motherBoard;
        return this;
    }

    public PcBuilder WithDdr(Ddr ddr)
    {
        _ddr = ddr;
        return this;
    }

    public PcBuilder WithCpuCoolingSystem(CpuCoolingSystem cpuCoolingSystem)
    {
        _cpuCoolingSystem = cpuCoolingSystem;
        return this;
    }

    public PcBuilder WithPcCase(PcCase pcCase)
    {
        _pcCase = pcCase;
        return this;
    }

    public PcBuilder WithPowerUnit(PowerUnit powerUnit)
    {
        _powerUnit = powerUnit;
        return this;
    }

    public PcBuilder WithSsd(Ssd ssd)
    {
        _ssd = ssd;
        return this;
    }

    public PcBuilder WithHdd(Hdd hdd)
    {
        _hdd = hdd;
        return this;
    }

    public PcBuilder WithVideoCard(VideoCard videoCard)
    {
        _videoCard = videoCard;
        return this;
    }

    public PcBuilder WithWifiAdapter(WiFiAdapter wiFiAdapter)
    {
        _wiFiAdapter = wiFiAdapter;
        return this;
    }

    public Pc Build()
    {
        return new Pc(
            _motherBoard ?? throw new ArgumentNullException(),
            _cpu ?? throw new ArgumentNullException(),
            _ddr ?? throw new ArgumentNullException(),
            _cpuCoolingSystem ?? throw new ArgumentNullException(),
            _pcCase ?? throw new ArgumentNullException(),
            _powerUnit ?? throw new ArgumentNullException(),
            _ssd,
            _hdd,
            _videoCard,
            _wiFiAdapter);
    }
}