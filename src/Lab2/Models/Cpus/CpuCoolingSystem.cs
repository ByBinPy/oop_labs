using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;

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
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (CpuCoolingSystem)obj;

        return Height == other.Height &&
               Width == other.Width &&
               Length == other.Length &&
               SupportSockets.SequenceEqual(other.SupportSockets) &&
               Tdp == other.Tdp;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Height, Width, Length, SupportSockets, Tdp);
    }
}