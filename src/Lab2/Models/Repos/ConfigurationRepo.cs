using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class ConfigurationRepo
{
    private readonly List<Pc> _pcs;
    public ConfigurationRepo()
    {
        _pcs = new List<Pc>()
        {
        };
    }

    public ConfigurationRepo(IList<Pc> dds)
    {
        _pcs = new List<Pc>(dds);
    }

    public ConfigurationRepo Add(Pc dd)
    {
        if (!RepoValidator.IsValidPc(dd))
            return new ConfigurationRepo();

        _pcs.Add(dd);

        return this;
    }

    public bool Update(Pc dd, Pc newPc)
    {
        if (_pcs.IndexOf(dd) == -1)
            return false;

        _pcs[_pcs.IndexOf(dd)] = newPc;

        return true;
    }

    public bool Delete(Pc dd)
    {
        return _pcs.Remove(dd);
    }

    public IList<Pc>? FindAll(Predicate<Pc> predicate) => _pcs.FindAll(predicate);
}