using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class CpuRepo
{
    private Collection<Cpu> _cpus;

    public CpuRepo()
    {
        _cpus = new Collection<Cpu>();
    }

    public CpuRepo(IList<Cpu> cpus)
    {
        _cpus = new Collection<Cpu>(cpus);
    }

    public CpuRepo Add(Cpu cpu)
    {
        if (!RepoValidator.IsValidCpu(cpu))
            return new CpuRepo();

        _cpus.Add(cpu);

        return this;
    }

    public bool Update(Cpu cpu, Cpu newCpu)
    {
        if (_cpus.IndexOf(cpu) == -1)
            return false;

        _cpus[_cpus.IndexOf(cpu)] = newCpu;

        return true;
    }

    public bool Delete(Cpu cpu)
    {
        return _cpus.Remove(cpu);
    }
}