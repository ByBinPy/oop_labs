using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Hdds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PcCases;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnits;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ssds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;

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

    public Configurator(MotherBoard motherBoard, Cpu cpu, CpuCoolingSystem cpuCoolingSystem, PowerUnit powerUnit, Ddr ddr, PcCase pcCase)
    {
        _motherBoard = motherBoard;
        _cpu = cpu;
        _cpuCoolingSystem = cpuCoolingSystem;
        _powerUnit = powerUnit;
        _ddr = ddr;
        _pcCase = pcCase;
    }

    public Pc Configurate()
    {
        if (_cpu == null || _cpuCoolingSystem == null || _ddr == null || _powerUnit == null || _pcCase == null)
            SelectCpus().SelectCpuCoolingSystems().ChooseCpuAndCooler().SelectDdr().SelectPcCase().SelectWifiAdapter();

        if (!_cpu?.GraphicCore ?? false)
            SelectVideoCard();

        if (_motherBoard.QtySataPort > 0)
            SelectHdd();
        SelectPowerUnit();
        return BuildPc();
    }

    private bool ContainCpuInComparable(IEnumerable<Cpu> comparableCpus)
    {
        if (_cpus != null)
        {
            foreach (Cpu cpu in _cpus)
            {
                foreach (Cpu biosCpu in comparableCpus)
                {
                    if (cpu.Equals(biosCpu))
                        return true;
                }
            }
        }

        return false;
    }

    private bool ContainCoolerSocketsInComparable(IEnumerable<Socket>? comparableSockets)
    {
        if (comparableSockets == null)
            return false;

        return _cpus != null && comparableSockets.Any(socket => socket.Version == _motherBoard.Socket.Version);
    }

    private Configurator SelectCpus()
    {
        _cpus = (List<Cpu>?)ComponentsContext.CpuRepo.FindAll(cpu => cpu.Socket.Version == _motherBoard.Socket.Version && cpu.DdrStandard.Version == _motherBoard.DdrStandard.Version);
        switch (_motherBoard.Bios.Type)
        {
            case nameof(Uefi):
                _cpus = _cpus?.FindAll(cpu => ContainCpuInComparable(BiosRepoContext.Uefi.ComparableCpus));
                break;
            case nameof(Intel):
                _cpus = _cpus?.FindAll(cpu => ContainCpuInComparable(BiosRepoContext.Intel.ComparableCpus));
                break;
            case nameof(Phoenix):
                _cpus = _cpus?.FindAll(cpu => ContainCpuInComparable(BiosRepoContext.Phoenix.ComparableCpus));
                break;
            case nameof(Ami):
                _cpus = _cpus?.FindAll(cpu => ContainCpuInComparable(BiosRepoContext.Ami.ComparableCpus));
                break;
        }

        return this;
    }

    private Configurator SelectCpuCoolingSystems()
    {
        _cpuCoolingSystems = (List<CpuCoolingSystem>?)ComponentsContext.CpuCoolingSystemRepo.FindAll(cpuCoolingSystem =>
            ContainCoolerSocketsInComparable(cpuCoolingSystem.SupportSockets as IEnumerable<Socket>));
        return this;
    }

    private Configurator ChooseCpuAndCooler()
    {
        if (_cpuCoolingSystems != null && _cpus != null)
        {
            foreach (Cpu cpu in _cpus)
            {
                _cpuCoolingSystem = _cpuCoolingSystems.Find(cooler => cooler.Tdp >= cpu.Tdp);
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
        _ddr = ComponentsContext.DdrRepo.FindAll(ddr => (ddr.Standard.Version == _motherBoard.DdrStandard.Version))?.MinBy(ssd => ssd.Power);
        return this;
    }

    private Configurator SelectPcCase()
    {
        _pcCase = ComponentsContext.PcCaseRepo.FindAll(pcCase => pcCase.MotherBoardFormFactor == _motherBoard.FormFactor)?.FirstOrDefault();
        return this;
    }

    private Configurator SelectWifiAdapter()
    {
        _wiFiAdapter = ComponentsContext.WiFiAdapterRepo.FindAll(wiFiAdapter => wiFiAdapter.PciEVersion == _motherBoard.PciE.Version)?.MinBy(wiFiAdapter => wiFiAdapter.Power);
        return this;
    }

    private Configurator SelectVideoCard()
    {
        _videoCard = ComponentsContext.VideoCardRepo.FindAll(videoCard => videoCard.VersionPciE.Version == _motherBoard.PciE.Version)?.MinBy(videoCards => videoCards.Power);
        return this;
    }

    private Configurator SelectHdd()
    {
        _hdd = ComponentsContext.HddRepo.FindAll(_ => true)?.MinBy(hdd => hdd.Power);
        return this;
    }

    private Configurator SelectSsd()
    {
        _ssd = ComponentsContext.SsdRepo.FindAll(_ => true)?.MinBy(ssd => ssd.Power);
        return this;
    }

    private int GetPowerSystem()
    {
        return (_ssd?.Power ?? 0) +
               (_cpu?.Power ?? 0) +
               (_ddr?.Power ?? 0) +
               (_hdd?.Power ?? 0) +
               (_videoCard?.Power ?? 0) +
               (_wiFiAdapter?.Power ?? 0);
    }

    private Configurator SelectPowerUnit()
    {
        int powerSystem = GetPowerSystem();
        _powerUnit = ComponentsContext.PowerUnitRepo.FindAll(powerUnit => powerUnit.PeakLoad > GetPowerSystem())?.MinBy(powerUnit => powerUnit.PeakLoad);
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