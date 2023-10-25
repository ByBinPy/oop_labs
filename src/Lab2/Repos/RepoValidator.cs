using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Hdds;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.PcCases;
using Itmo.ObjectOrientedProgramming.Lab2.Ssds;
using Itmo.ObjectOrientedProgramming.Lab2.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

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

    public static bool IsValidMotherBoard(MotherBoard motherBoard)
    {
        return motherBoard is
        {
            Socket: not null,
            QtyPcieLine: > 0,
            QtySataPort: > 0,
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
            Depth: > 0,
            SupportSockets: not null,
            Tdp: > 0
        };
    }
}