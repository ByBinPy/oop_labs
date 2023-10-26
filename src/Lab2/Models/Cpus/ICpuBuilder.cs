using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public interface ICpuBuilder
{
    ICpuBuilder WithCoreFrequency(double coreFrequency);
    ICpuBuilder WithQtyCore(int qtyCore);
    ICpuBuilder WithSocket(Socket socket);
    ICpuBuilder WithDdrStandard(DdrStandard standard);
    ICpuBuilder WithQtyRamSlots(int qtyRamSlots);
    ICpuBuilder WithRamFrequency(double ramFrequency);
    ICpuBuilder WithGraphicCore(bool graphicCore);
    ICpuBuilder WithTdp(int tdp);
    ICpuBuilder WithPower(int power);
    Cpu Build();
}