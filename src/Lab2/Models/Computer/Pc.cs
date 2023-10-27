using Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Hdds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PcCases;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnits;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ssds;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;

public class Pc
{
    public Pc(
        MotherBoard motherBoard,
        Cpu cpu,
        Ddr ddr,
        CpuCoolingSystem cpuCoolingSystem,
        PcCase pcCase,
        PowerUnit powerUnitPc,
        Ssd? ssd,
        Hdd? hdd,
        VideoCard? videoCard,
        WiFiAdapter? wiFiAdapter)
    {
        MotherBoardPc = motherBoard;
        CpuPc = cpu;
        DdrPc = ddr;
        CpuCoolingSystemPc = cpuCoolingSystem;
        PcCasePc = pcCase;
        PowerUnitPc = powerUnitPc;
        SsdPc = ssd;
        HddPc = hdd;
        VideoCardPc = videoCard;
        WiFiAdapterPc = wiFiAdapter;
    }

    public MotherBoard MotherBoardPc { get; }
    public Cpu CpuPc { get; }
    public Ddr DdrPc { get; }
    public CpuCoolingSystem CpuCoolingSystemPc { get; }
    public PcCase PcCasePc { get; }
    public PowerUnit PowerUnitPc { get; }
    public Ssd? SsdPc { get; }
    public Hdd? HddPc { get; }
    public VideoCard? VideoCardPc { get; }
    public WiFiAdapter? WiFiAdapterPc { get; }
}