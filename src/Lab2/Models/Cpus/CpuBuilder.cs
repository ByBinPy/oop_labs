using System;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public class CpuBuilder : ICpuBuilder
{
   private double _coreFrequency;
   private int _qtyCore;
   private Socket? _socket;
   private DdrStandard? _ddrStandard;
   private int _qtyRamSlots;
   private double _ramFrequency;
   private bool _graphicCore;
   private int _tdp;
   private int _power;

   public CpuBuilder() { }

   public CpuBuilder(Cpu cpu)
   {
       if (cpu == null) return;
       _coreFrequency = cpu.CoreFrequency;
       _qtyCore = cpu.QtyCore;
       _socket = cpu.Socket;
       _ddrStandard = cpu.DdrStandard;
       _qtyRamSlots = cpu.QtyRamSlots;
       _ramFrequency = cpu.RamFrequency;
       _graphicCore = cpu.GraphicCore;
       _tdp = cpu.Tdp;
       _power = cpu.Power;
   }

   public ICpuBuilder WithCoreFrequency(double coreFrequency)
   {
       _coreFrequency = coreFrequency;
       return this;
   }

   public ICpuBuilder WithQtyCore(int qtyCore)
   {
       _qtyCore = qtyCore;
       return this;
   }

   public ICpuBuilder WithSocket(Socket socket)
   {
       _socket = socket;
       return this;
   }

   public ICpuBuilder WithDdrStandard(DdrStandard standard)
   {
       _ddrStandard = standard;
       return this;
   }

   public ICpuBuilder WithQtyRamSlots(int qtyRamSlots)
   {
       _qtyRamSlots = qtyRamSlots;
       return this;
   }

   public ICpuBuilder WithRamFrequency(double ramFrequency)
   {
       _ramFrequency = ramFrequency;
       return this;
   }

   public ICpuBuilder WithGraphicCore(bool graphicCore)
   {
       _graphicCore = graphicCore;
       return this;
   }

   public ICpuBuilder WithTdp(int tdp)
   {
       _tdp = tdp;
       return this;
   }

   public ICpuBuilder WithPower(int power)
   {
       _power = power;
       return this;
   }

   public Cpu Build()
   {
       return new Cpu(
           _coreFrequency,
           _qtyCore,
           _socket ?? throw new ArgumentException(),
           _ddrStandard ?? throw new ArgumentException(),
           _qtyRamSlots,
           _ramFrequency,
           _graphicCore,
           _tdp,
           _power);
   }
}