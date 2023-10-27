using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;

public interface ICpuCoolingSystemBuilder
{
    ICpuCoolingSystemBuilder WithHeight(int height);
    ICpuCoolingSystemBuilder WithWidth(int width);
    ICpuCoolingSystemBuilder WithLength(int length);
    ICpuCoolingSystemBuilder WithSupportSockets(Collection<Socket> sockets);
    ICpuCoolingSystemBuilder WithTdp(int tdp);
    CpuCoolingSystem Build();
}