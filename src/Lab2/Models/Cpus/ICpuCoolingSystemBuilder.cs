using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public interface ICpuCoolingSystemBuilder
{
    ICpuCoolingSystemBuilder WithHeight(int height);
    ICpuCoolingSystemBuilder WithWidth(int width);
    ICpuCoolingSystemBuilder WithLength(int length);
    ICpuCoolingSystemBuilder WithSupportSockets(Collection<Socket> sockets);
    ICpuCoolingSystemBuilder WithTdp(int tdp);
    CpuCoolingSystem Build();
}