using Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Hdds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PcCases;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnits;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ssds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

internal abstract class RepoValidator
{
    public static bool IsValidCpu(Cpu cpu)
    {
        return cpu is
        {
            DdrStandard: not null,
            Socket: not null,
            Power: > 0,
            QtyCore: > 0,
            CoreFrequency: > 0,
            QtyRamSlots: > 0,
            RamFrequency: > 0,
            Tdp: > 0
        };
    }

    public static bool IsValidDdr(Ddr ddr)
    {
        return ddr is
        {
            QtyMemory: > 0,
            Jedec: not null,
            DefaultVoltage: > 0,
            XmpProfiles: not null,
            FormFactor: not null,
            Standard: not null,
            Power: > 0
        };
    }

    public static bool IsValidPowerUnit(PowerUnit powerUnit)
    {
        return powerUnit.PeakLoad > 0;
    }

    public static bool IsValidWiFiAdapter(WiFiAdapter wiFiAdapter)
    {
        return wiFiAdapter is
        {
            WiFiStandard: not null,
            PciEVersion: not null,
            Power: > 0
        };
    }

    public static bool IsValidPc(Pc pc)
    {
        return pc is
        {
            MotherBoardPc: not null,
            CpuPc: not null,
            DdrPc: not null,
            CpuCoolingSystemPc: not null,
            PcCasePc: not null,
            PowerUnitPc: not null,
        };
    }

    public static bool IsValidMotherBoard(MotherBoard motherBoard)
    {
        return motherBoard is
        {
            Socket: not null,
            QtyPcieLine: > 0,
            QtySataPort: >= 0,
            Chipset: not null,
            QtyRamSlot: > 0,
            Bios: not null
        };
    }

    public static bool IsValidVideoCard(VideoCard videoCard)
    {
        return videoCard is
        {
            Width: > 0,
            Height: > 0,
            QtyMemory: > 0,
            VersionPciE: not null,
            ChipFrequency: > 0,
            Power: > 0
        };
    }

    public static bool IsValidHdd(Hdd hdd)
    {
        return hdd is
        {
            Capacity: > 0,
            SpedRotation: > 0,
            Power: > 0
        };
    }

    public static bool IsValidSsd(Ssd ssd)
    {
        return ssd is
        {
            Capacity: > 0,
            HowConnection: not null,
            MaxSpeed: > 0,
            Power: > 0
        };
    }

    public static bool IsValidPcCase(PcCase pcCase)
    {
        return pcCase is
        {
            LenghtVideoCard: > 0,
            WidthVideoCard: > 0,
            Length: > 0,
            Depth: > 0,
            Width: > 0
        };
    }

    public static bool IsValidCpuCoolingSystem(CpuCoolingSystem cpuCoolingSystem)
    {
        return cpuCoolingSystem is
        {
            Height: > 0,
            Width: > 0,
            Length: > 0,
            SupportSockets: not null,
            Tdp: > 0
        };
    }
}