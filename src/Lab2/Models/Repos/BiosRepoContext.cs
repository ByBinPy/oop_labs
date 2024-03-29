using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public record BiosRepoContext
{
    public static BiosCpuRepo<Phoenix> Phoenix { get; } = (BiosCpuRepo<Phoenix>)new BiosCpuRepo<Phoenix>()
        .Add(new CpuBuilder()
            .WithCoreFrequency(3.1)
            .WithQtyCore(4).WithSocket(new Socket("AM4"))
            .WithDdrStandard(new DdrStandard("DDR4"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(2667)
            .WithGraphicCore(false)
            .WithTdp(65)
            .WithPower(70)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(4.9)
            .WithQtyCore(10)
            .WithSocket(new Socket("LGA 1700"))
            .WithDdrStandard(new DdrStandard("DDR4"))
            .WithQtyRamSlots(4)
            .WithRamFrequency(3570)
            .WithGraphicCore(false)
            .WithTdp(150)
            .WithPower(157)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(4)
            .WithQtyCore(4)
            .WithSocket(new Socket("AM3"))
            .WithDdrStandard(new DdrStandard("DDR3"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(1866)
            .WithGraphicCore(false)
            .WithTdp(95)
            .WithPower(110)
            .Build());

    public static BiosCpuRepo<Ami> Ami { get; } = (BiosCpuRepo<Ami>)new BiosCpuRepo<Ami>()
        .Add(new CpuBuilder()
            .WithCoreFrequency(3.3)
            .WithQtyCore(2)
            .WithSocket(new Socket("LGA 1151"))
            .WithDdrStandard(new DdrStandard("DDR3L"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(2133)
            .WithGraphicCore(true)
            .WithTdp(54)
            .WithPower(65)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(4.2)
            .WithQtyCore(6)
            .WithSocket(new Socket("AM4"))
            .WithDdrStandard(new DdrStandard("DDR4"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(3200)
            .WithGraphicCore(true)
            .WithTdp(65)
            .WithPower(73)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(5.6)
            .WithQtyCore(12)
            .WithSocket(new Socket("AM5"))
            .WithDdrStandard(new DdrStandard("DDR5"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(5200)
            .WithGraphicCore(true)
            .WithTdp(170)
            .WithPower(200)
            .Build());

    public static BiosCpuRepo<Intel> Intel { get; } = (BiosCpuRepo<Intel>)new BiosCpuRepo<Intel>()
        .Add(new CpuBuilder()
            .WithCoreFrequency(4.8)
            .WithQtyCore(18)
            .WithSocket(new Socket("LGA 2066"))
            .WithDdrStandard(new DdrStandard("DDR5"))
            .WithQtyRamSlots(4)
            .WithRamFrequency(5500)
            .WithGraphicCore(false)
            .WithTdp(165)
            .WithPower(180)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(4.4)
            .WithQtyCore(6)
            .WithSocket(new Socket("LGA 1200"))
            .WithDdrStandard(new DdrStandard("DDR4"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(3202)
            .WithGraphicCore(false)
            .WithTdp(65)
            .WithPower(75)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(4.3)
            .WithQtyCore(6)
            .WithSocket(new Socket("LGA 1200"))
            .WithDdrStandard(new DdrStandard("DDR4"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(2666)
            .WithGraphicCore(true)
            .WithTdp(65)
            .WithPower(74)
            .Build());

    public static BiosCpuRepo<Uefi> Uefi { get; } = (BiosCpuRepo<Uefi>)new BiosCpuRepo<Uefi>()
        .Add(new CpuBuilder()
            .WithCoreFrequency(3.6)
            .WithQtyCore(4)
            .WithSocket(new Socket("LGA 1151"))
            .WithDdrStandard(new DdrStandard("DDR3"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(2400)
            .WithGraphicCore(true)
            .WithTdp(65)
            .WithPower(74)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(1.9)
            .WithQtyCore(2)
            .WithSocket(new Socket("LGA 1150"))
            .WithDdrStandard(new DdrStandard("DDR2"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(1320)
            .WithGraphicCore(false)
            .WithTdp(105)
            .WithPower(114)
            .Build())
        .Add(new CpuBuilder()
            .WithCoreFrequency(1000)
            .WithQtyCore(4)
            .WithSocket(new Socket("AM3"))
            .WithDdrStandard(new DdrStandard("DDR2"))
            .WithQtyRamSlots(2)
            .WithRamFrequency(1267)
            .WithGraphicCore(false)
            .WithTdp(85)
            .WithPower(100)
            .Build());
}