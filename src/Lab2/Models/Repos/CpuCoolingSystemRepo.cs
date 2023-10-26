using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class CpuCoolingSystemRepo
{
    private readonly Collection<CpuCoolingSystem> _cpuCoolingSystems;
    public CpuCoolingSystemRepo()
    {
        _cpuCoolingSystems = new Collection<CpuCoolingSystem>()
        {
            new CpuCoolingSystemBuilder().WithHeight(152).WithWidth(132).WithLength(85).WithTdp(130).WithSupportSockets(new Collection<Socket> { new Socket("AM4"), new Socket("AM3"), new Socket("FM2"), new Socket("LGA 1151") }).Build(),
            new CpuCoolingSystemBuilder().WithHeight(70).WithWidth(95).WithLength(95).WithTdp(110).WithSupportSockets(new Collection<Socket> { new Socket("LGA 1700") }).Build(),
            new CpuCoolingSystemBuilder().WithHeight(123).WithWidth(100).WithLength(65).WithTdp(130).WithSupportSockets(new Collection<Socket> { new Socket("AM4"), new Socket("LGA 1150"), new Socket("LGA 1200"), new Socket("LGA 1700") }).Build(),
        };
    }

    public CpuCoolingSystemRepo(IList<CpuCoolingSystem> cpuCoolingSystems)
    {
        _cpuCoolingSystems = new Collection<CpuCoolingSystem>(cpuCoolingSystems);
    }

    public CpuCoolingSystemRepo Add(CpuCoolingSystem cpuCoolingSystem)
    {
        if (!RepoValidator.IsValidCpuCoolingSystem(cpuCoolingSystem))
            return new CpuCoolingSystemRepo();

        _cpuCoolingSystems.Add(cpuCoolingSystem);

        return this;
    }

    public bool Update(CpuCoolingSystem cpuCoolingSystem, CpuCoolingSystem newCpuCoolingSystem)
    {
        if (_cpuCoolingSystems.IndexOf(cpuCoolingSystem) == -1)
            return false;

        _cpuCoolingSystems[_cpuCoolingSystems.IndexOf(cpuCoolingSystem)] = newCpuCoolingSystem;

        return true;
    }

    public bool Delete(CpuCoolingSystem cpuCoolingSystem)
    {
        return _cpuCoolingSystems.Remove(cpuCoolingSystem);
    }
}