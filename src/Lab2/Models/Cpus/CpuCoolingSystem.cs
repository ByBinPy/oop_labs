using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public class CpuCoolingSystem
{
    public CpuCoolingSystem(
        int height,
        int width,
        int length,
        IReadOnlyCollection<Socket> supportSockets,
        int tdp)
    {
        Height = height;
        Width = width;
        Length = length;
        SupportSockets = supportSockets;
        Tdp = tdp;
    }

    public int Height { get; }
    public int Width { get; }
    public int Length { get; }
    public IReadOnlyCollection<Socket> SupportSockets { get; }
    public int Tdp { get; }
}