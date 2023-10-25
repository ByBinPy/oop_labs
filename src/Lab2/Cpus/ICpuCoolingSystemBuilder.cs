using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public interface ICpuCoolingSystemBuilder
{
    /*
    public int Height { get; }
    public int Width { get; }
    public int Depth { get; }
    public IReadOnlyCollection<Socket> SupportSockets { get; }
    public int Tdp { get; }
     */
    ICpuCoolingSystemBuilder WithHeight(int height);
    ICpuCoolingSystemBuilder WithWidth(int width);
    ICpuCoolingSystemBuilder WithDepth(int depth);
    ICpuCoolingSystemBuilder WithSupportSockets(Collection<Socket> sockets);
    ICpuCoolingSystemBuilder WithTdp(int tdp);
    CpuCoolingSystem Build();
}