using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.PcCases;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public abstract class Validator
{
    public static IList<Message> IsValidPc(Pc pc)
    {
        var messages = new List<Message>();

        if (pc == null)
            return messages;

        if (CheckCpu(pc.MotherBoardPc, pc.CpuPc).TextMessage != Message.Success) messages.Add(CheckCpu(pc.MotherBoardPc, pc.CpuPc));

        if (CheckDdr(pc.MotherBoardPc, pc.DdrPc).TextMessage != Message.Success) messages.Add(CheckDdr(pc.MotherBoardPc, pc.DdrPc));

        if (CheckGraphicCoreOrVideoCard(pc.MotherBoardPc, pc.CpuPc, pc.VideoCardPc).TextMessage != Message.Success) messages.Add(CheckGraphicCoreOrVideoCard(pc.MotherBoardPc, pc.CpuPc, pc.VideoCardPc));

        if (pc.WiFiAdapterPc != null && CheckWiFiAdapter(pc.MotherBoardPc, pc.WiFiAdapterPc).TextMessage != Message.Success) messages.Add(CheckWiFiAdapter(pc.MotherBoardPc, pc.WiFiAdapterPc));

        if (CheckPcCase(pc.MotherBoardPc, pc.PcCasePc).TextMessage != Message.Success) messages.Add(CheckPcCase(pc.MotherBoardPc, pc.PcCasePc));

        if (CheckPowerUnit(pc).TextMessage != Message.Success) messages.Add(CheckPowerUnit(pc));

        if (CheckCpuCooler(pc.CpuPc, pc.CpuCoolingSystemPc).TextMessage != Message.Success) messages.Add(CheckCpuCooler(pc.CpuPc, pc.CpuCoolingSystemPc));

        return messages;
    }

    private static Message CheckCpu(MotherBoard motherBoard, Cpu cpu)
    {
        return motherBoard.Socket == cpu.Socket ? new Message(Message.Success) : new Message(Message.Incompatible + nameof(cpu));
    }

    private static Message CheckDdr(MotherBoard motherBoard, Ddr ddr)
    {
        return motherBoard.DdrStandard == ddr.Standard ? new Message(Message.Success) : new Message(Message.Incompatible + nameof(ddr));
    }

    private static Message CheckGraphicCoreOrVideoCard(MotherBoard motherBoard, Cpu cpu, VideoCard? videoCard)
    {
        if (cpu.GraphicCore)
            return new Message(Message.Success);

        if (videoCard == null)
            return new Message(Message.ConditionalComponent + nameof(videoCard));

        return motherBoard.PciE != videoCard.VersionPciE ? new Message(Message.Incompatible + nameof(videoCard)) : new Message(Message.Success);
    }

    private static Message CheckWiFiAdapter(MotherBoard motherBoard, WiFiAdapter wiFiAdapter)
    {
        return wiFiAdapter.PciEVersion != motherBoard.PciE.Version ? new Message(Message.Incompatible + nameof(wiFiAdapter)) : new Message(Message.Success);
    }

    private static bool IsValidDispersionPower(int unitPower, int systemPower)
    {
        // Check on valid difference between cpu.Tdp and cpuCoolingSystem.Tdp
        return ((systemPower - unitPower) / systemPower) * 100 < 30;
    }

    private static int GetSystemPower(Pc pc)
    {
        return pc.CpuPc.Power +
               pc.DdrPc.Power +
               (pc.HddPc?.Power ?? 0) +
               (pc.SsdPc?.Power ?? 0) +
               (pc.VideoCardPc?.Power ?? 0) +
               (pc.WiFiAdapterPc?.Power ?? 0);
    }

    private static Message CheckPcCase(MotherBoard motherBoard, PcCase pcCase)
    {
        return motherBoard.FormFactor != pcCase.MotherBoardFormFactor ? new Message(Message.Incompatible + nameof(pcCase)) : new Message(Message.Success);
    }

    private static Message CheckPowerUnit(Pc pc)
    {
        if (pc.PowerUnitPc.PeakLoad < GetSystemPower(pc) && IsValidDispersionPower(pc.PowerUnitPc.PeakLoad, GetSystemPower(pc)))
        {
            return new Message(Message.DisclaimerOfWarrantyDueTo + nameof(pc.PowerUnitPc));
        }

        return pc.PowerUnitPc.PeakLoad >= GetSystemPower(pc) ? new Message(Message.Success) : new Message(Message.Incompatible + nameof(pc.PowerUnitPc));
    }

    private static Message CheckCpuCooler(Cpu cpu, CpuCoolingSystem cpuCoolingSystem)
    {
        return IsValidDispersionPower(cpu.Tdp, cpuCoolingSystem.Tdp) ? new Message(Message.DisclaimerOfWarrantyDueTo + nameof(CpuCoolingSystem)) : new Message(Message.Success);
    }
}