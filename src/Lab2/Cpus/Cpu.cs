using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public class Cpu
{
    public Cpu(int coreFrequency, int qtyCore, Socket socket, DdrStandard ddrStandard, int qtyRamSlots, int ramFrequency, int tdp, int power)
    {
        CoreFrequency = coreFrequency;
        QtyCore = qtyCore;
        Socket = socket;
        DdrStandard = ddrStandard;
        QtyRamSlots = qtyRamSlots;
        RamFrequency = ramFrequency;
        Tdp = tdp;
        Power = power;
    }

    public int CoreFrequency { get; }
    public int QtyCore { get; }
    public Socket Socket { get; }
    public DdrStandard DdrStandard { get; }
    public int QtyRamSlots { get; }
    public int RamFrequency { get; }
    public int Tdp { get; }
    public int Power { get; }
}