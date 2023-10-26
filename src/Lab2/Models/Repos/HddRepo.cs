using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Hdds;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class HddRepo
{
    private Collection<Hdd> _dds;

    public HddRepo()
    {
        _dds = new Collection<Hdd>();
    }

    public HddRepo(IList<Hdd> dds)
    {
        _dds = new Collection<Hdd>(dds);
    }

    public HddRepo Add(Hdd dd)
    {
        if (!RepoValidator.IsValidHdd(dd))
            return new HddRepo();

        _dds.Add(dd);

        return this;
    }

    public bool Update(Hdd dd, Hdd newHdd)
    {
        if (_dds.IndexOf(dd) == -1)
            return false;

        _dds[_dds.IndexOf(dd)] = newHdd;

        return true;
    }

    public bool Delete(Hdd dd)
    {
        return _dds.Remove(dd);
    }
}