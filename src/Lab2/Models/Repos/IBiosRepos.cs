using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public interface IBiosRepos<T>
    where T : IBios
{
    IEnumerable<Cpu> ComparableCpus { get; }
    IBiosRepos<T> Add(Cpu cpu);
    bool Delete(Cpu cpu);
    bool Update(Cpu cpu, Cpu newCpu);
}