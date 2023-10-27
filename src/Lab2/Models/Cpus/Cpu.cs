using System;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;

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
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (Cpu)obj;

        return Math.Abs(CoreFrequency - other.CoreFrequency) < 0.0000001 &&
               QtyCore == other.QtyCore &&
               Socket.Version == other.Socket.Version &&
               DdrStandard.Version == other.DdrStandard.Version &&
               QtyRamSlots == other.QtyRamSlots &&
               Math.Abs(RamFrequency - other.RamFrequency) < 0.0000001 &&
               GraphicCore == other.GraphicCore &&
               Tdp == other.Tdp &&
               Power == other.Power;
    }

    public override int GetHashCode()
    {
        var hashCode = default(HashCode);
        hashCode.Add(CoreFrequency);
        hashCode.Add(QtyCore);
        hashCode.Add(Socket);
        hashCode.Add(DdrStandard);
        hashCode.Add(QtyRamSlots);
        hashCode.Add(RamFrequency);
        hashCode.Add(GraphicCore);
        hashCode.Add(Tdp);
        hashCode.Add(Power);
        return hashCode.ToHashCode();
    }

    protected bool Equals(Cpu other)
    {
        return other != null && CoreFrequency.Equals(other.CoreFrequency) && QtyCore == other.QtyCore && Socket.Equals(other.Socket) && DdrStandard.Equals(other.DdrStandard) && QtyRamSlots == other.QtyRamSlots && RamFrequency.Equals(other.RamFrequency) && GraphicCore == other.GraphicCore && Tdp == other.Tdp && Power == other.Power;
    }
}