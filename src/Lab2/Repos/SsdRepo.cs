using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Ssds;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class SsdRepo
{
    private Collection<Ssd> _ssds;

    public SsdRepo()
    {
        _ssds = new Collection<Ssd>();
    }

    public SsdRepo(IList<Ssd> ssds)
    {
        _ssds = new Collection<Ssd>(ssds);
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
}