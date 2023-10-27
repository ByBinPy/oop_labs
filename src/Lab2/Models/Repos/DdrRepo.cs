using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class DdrRepo
{
    private readonly List<Ddr> _ddrs;
    public DdrRepo()
    {
        _ddrs = new List<Ddr>()
        {
        };
    }

    public DdrRepo(IList<Ddr> dds)
    {
        _ddrs = new List<Ddr>(dds);
    }

    public DdrRepo Add(Ddr dd)
    {
        if (!RepoValidator.IsValidDdr(dd))
            return new DdrRepo();

        _ddrs.Add(dd);

        return this;
    }

    public bool Update(Ddr dd, Ddr newDdr)
    {
        if (_ddrs.IndexOf(dd) == -1)
            return false;

        _ddrs[_ddrs.IndexOf(dd)] = newDdr;

        return true;
    }

    public bool Delete(Ddr dd)
    {
        return _ddrs.Remove(dd);
    }

    public IList<Ddr>? FindAll(Predicate<Ddr> predicate) => _ddrs.FindAll(predicate);
}