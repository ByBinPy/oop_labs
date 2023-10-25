using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public interface ICpuBuilder
{
    ICpuBuilder WithCoreFrequency(int coreFrequency);
    ICpuBuilder WithQtyCore(int qtyCore);
    ICpuBuilder WithSocket(Socket socket);
    ICpuBuilder WithDdtStandard(DdrStandard standard);
    ICpuBuilder WithQtyRamSlots(int qtyRamSlots);
    ICpuBuilder WithRamFrequency(int ramFrequency);
    ICpuBuilder WithGraphicCore(bool graphicCore);
    ICpuBuilder WithTdp(int tdp);
    ICpuBuilder WithPower(int power);
    Cpu Build();
}