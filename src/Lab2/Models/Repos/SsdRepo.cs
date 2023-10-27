using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Ssds;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class SsdRepo
{
    private readonly List<Ssd> _ssds;

    public SsdRepo()
    {
        _ssds = new List<Ssd>();
    }

    public SsdRepo(IList<Ssd> ssds)
    {
        _ssds = new List<Ssd>(ssds);
    }

    public SsdRepo Add(Ssd ssd)
    {
        if (!RepoValidator.IsValidSsd(ssd))
            return new SsdRepo();

        _ssds.Add(ssd);

        return this;
    }

    public bool Update(Ssd ssd, Ssd newSsd)
    {
        if (_ssds.IndexOf(ssd) == -1)
            return false;

        _ssds[_ssds.IndexOf(ssd)] = newSsd;

        return true;
    }

    public bool Delete(Ssd ssd)
    {
        return _ssds.Remove(ssd);
    }

    public IList<Ssd>? FindAll(Predicate<Ssd> predicate) => _ssds.FindAll(predicate);
}