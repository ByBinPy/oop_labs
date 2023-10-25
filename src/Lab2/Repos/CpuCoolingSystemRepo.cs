using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class CpuCoolingSystemRepo
{
    private Collection<CpuCoolingSystem> _cpuCoolingSystems;

    public CpuCoolingSystemRepo()
    {
        _cpuCoolingSystems = new Collection<CpuCoolingSystem>();
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