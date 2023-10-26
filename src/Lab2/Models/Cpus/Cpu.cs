using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public class Cpu
{
    public Cpu(
        double coreFrequency,
        int qtyCore,
        Socket socket,
        DdrStandard ddrStandard,
        int qtyRamSlots,
        double ramFrequency,
        bool graphicCore,
        int tdp,
        int power)
    {
        CoreFrequency = coreFrequency;
        QtyCore = qtyCore;
        Socket = socket;
        DdrStandard = ddrStandard;
        QtyRamSlots = qtyRamSlots;
        GraphicCore = graphicCore;
        RamFrequency = ramFrequency;
        Tdp = tdp;
        Power = power;
    }

    public double CoreFrequency { get; }
    public int QtyCore { get; }
    public Socket Socket { get; }
    public DdrStandard DdrStandard { get; }
    public int QtyRamSlots { get; }
    public double RamFrequency { get; }
    public bool GraphicCore { get; }
    public int Tdp { get; }
    public int Power { get; }
}