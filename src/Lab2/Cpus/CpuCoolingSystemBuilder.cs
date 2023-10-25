using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpus;

public class CpuCoolingSystemBuilder : ICpuCoolingSystemBuilder
{
    private int _height;
    private int _width;
    private int _depth;
    private IReadOnlyCollection<Socket>? _supportSockets;
    private int _tdp;

    public CpuCoolingSystemBuilder() { }

    public CpuCoolingSystemBuilder(CpuCoolingSystem cpuCoolingSystem)
    {
        if (cpuCoolingSystem == null)

            return;

        _height = cpuCoolingSystem.Height;
        _width = cpuCoolingSystem.Width;
        _depth = cpuCoolingSystem.Depth;
        _supportSockets = cpuCoolingSystem.SupportSockets;
        _tdp = cpuCoolingSystem.Tdp;
    }

    public ICpuCoolingSystemBuilder WithHeight(int height)
    {
        _height = height;

        return this;
    }

    public ICpuCoolingSystemBuilder WithWidth(int width)
    {
        _width = width;

        return this;
    }

    public ICpuCoolingSystemBuilder WithDepth(int depth)
    {
        _depth = depth;

        return this;
    }

    public ICpuCoolingSystemBuilder WithSupportSockets(Collection<Socket> sockets)
    {
        _supportSockets = new ReadOnlyCollection<Socket>(sockets);

        return this;
    }

    public ICpuCoolingSystemBuilder WithTdp(int tdp)
    {
        _tdp = tdp;

        return this;
    }

    public CpuCoolingSystem Build()
    {
        return new CpuCoolingSystem(
            _height,
            _width,
            _depth,
            _supportSockets ?? throw new ArgumentNullException(),
            _tdp);
    }
}