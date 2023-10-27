using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class BiosCpuRepo<T> : IBiosRepos<T>
    where T : IBios
{
    private readonly List<Cpu> _comparableCpus = new List<Cpu>();

    public IEnumerable<Cpu> ComparableCpus => _comparableCpus;

    public IBiosRepos<T> Add(Cpu cpu)
    {
        if (RepoValidator.IsValidCpu(cpu))
            _comparableCpus.Add(cpu);

        return this;
    }

    public bool Delete(Cpu cpu)
    {
        return _comparableCpus.Remove(cpu);
    }

    public bool Update(Cpu cpu, Cpu newCpu)
    {
        if (!_comparableCpus.Contains(cpu))
            return false;

        _comparableCpus[_comparableCpus.IndexOf(cpu)] = newCpu;

        return true;
    }
}