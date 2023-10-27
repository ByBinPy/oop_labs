using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Hdds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.PcCases;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnits;
using Itmo.ObjectOrientedProgramming.Lab2.Ssds;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;
public class Configurator
{
    private readonly MotherBoard _motherBoard;
    private List<Cpu>? _cpus;
    private List<CpuCoolingSystem>? _cpuCoolingSystems;
    private Cpu? _cpu;
    private CpuCoolingSystem? _cpuCoolingSystem;
    private Ddr? _ddr;
    private PcCase? _pcCase;
    private PowerUnit? _powerUnit;
    private Ssd? _ssd;
    private Hdd? _hdd;
    private VideoCard? _videoCard;
    private WiFiAdapter? _wiFiAdapter;
    public Configurator(MotherBoard motherBoard)
    {
        _motherBoard = motherBoard;
    }

    public Pc Configurate()
    {
        this.SelectCpus().SelectCpuCoolingSystems().ChooseCpuAndCooler().SelectDdr().SelectPcCase().SelectWifiAdapter();
        if (_cpu?.GraphicCore ?? false)
            this.SelectVideoCard();

        if (_motherBoard.QtySataPort > 0)
            this.SelectHdd();

        return this.BuildPc();
    }

    private Configurator SelectCpus()
    {
        _cpus = (List<Cpu>?)ComponentsContext.CpuRepo.FindAll((Cpu cpu) => cpu.Socket == _motherBoard.Socket && cpu.DdrStandard == _motherBoard.DdrStandard);
        switch (_motherBoard.Bios.Type)
        {
            case nameof(Uefi):
                _cpus = _cpus?.FindAll((Cpu cpu) => BiosRepoContext.Uefi.ComparableCpus.Contains(cpu));
                break;
            case nameof(Intel):
                _cpus = _cpus?.FindAll((Cpu cpu) => BiosRepoContext.Intel.ComparableCpus.Contains(cpu));
                break;
            case nameof(Phoenix):
                _cpus = _cpus?.FindAll((Cpu cpu) => BiosRepoContext.Phoenix.ComparableCpus.Contains(cpu));
                break;
            case nameof(Ami):
                _cpus = _cpus?.FindAll((Cpu cpu) => BiosRepoContext.Ami.ComparableCpus.Contains(cpu));
                break;
        }

        return this;
    }

    private Configurator SelectCpuCoolingSystems()
    {
        _cpuCoolingSystems = (List<CpuCoolingSystem>?)ComponentsContext.CpuCoolingSystemRepo.FindAll((CpuCoolingSystem cpuCoolingSystem) => cpuCoolingSystem.SupportSockets.Contains(_motherBoard.Socket));
        return this;
    }

    private Configurator ChooseCpuAndCooler()
    {
        if (_cpuCoolingSystems != null && _cpus != null)
        {
            foreach (Cpu cpu in _cpus)
            {
                _cpuCoolingSystem = _cpuCoolingSystems.Find((CpuCoolingSystem cooler) => cooler.Tdp >= cpu.Tdp);
                if (_cpuCoolingSystem != null)
                {
                    _cpu = cpu;
                    return this;
                }
            }
        }

        return this;
    }

    private Configurator SelectDdr()
    {
        _ddr = ComponentsContext.DdrRepo.FindAll((Ddr ddr) => (ddr.Standard == _motherBoard.DdrStandard))?.MinBy(ssd => ssd.Power);
        return this;
    }

    private Configurator SelectPcCase()
    {
        _pcCase = ComponentsContext.PcCaseRepo.FindAll((PcCase pcCase) => pcCase.MotherBoardFormFactor == _motherBoard.FormFactor)?.FirstOrDefault();
        return this;
    }

    private Configurator SelectWifiAdapter()
    {
        _wiFiAdapter = ComponentsContext.WiFiAdapterRepo.FindAll((WiFiAdapter wiFiAdapter) => wiFiAdapter.PciEVersion == _motherBoard.PciE.Version)?.MinBy(wiFiAdapter => wiFiAdapter.Power);
        return this;
    }

    private Configurator SelectVideoCard()
    {
        _videoCard = ComponentsContext.VideoCardRepo.FindAll((VideoCard videoCard) => videoCard.VersionPciE == _motherBoard.PciE)?.MinBy(videoCards => videoCards.Power);
        return this;
    }

    private Configurator SelectHdd()
    {
        _hdd = ComponentsContext.HddRepo.FindAll((Hdd hdd) => true)?.MinBy(hdd => hdd.Power);
        return this;
    }

    private Configurator SelectSsd()
    {
        _ssd = ComponentsContext.SsdRepo.FindAll((Ssd ssd) => true)?.MinBy(ssd => ssd.Power);
        return this;
    }

    private int GetPowerSystem()
    {
        return _ssd?.Power ?? 0 +
               _cpu?.Power ?? 0 +
               _ddr?.Power ?? 0 +
               _hdd?.Power ?? 0 +
               _videoCard?.Power ?? 0 +
               _wiFiAdapter?.Power ?? 0;
    }

    private Configurator SelectPowerUnit()
    {
        _powerUnit = ComponentsContext.PowerUnitRepo.FindAll((PowerUnit powerUnit) => powerUnit.PeakLoad > GetPowerSystem())?.MinBy(powerUnit => powerUnit.PeakLoad);
        return this;
    }

    private Pc BuildPc()
    {
        return new Pc(
            _motherBoard,
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