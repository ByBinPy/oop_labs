using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Hdds;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class HddRepo
{
    private readonly List<Hdd> _hdds;
    public HddRepo()
    {
        _hdds = new List<Hdd>()
        {
            new HddBuilder()
                .WithCapacity(512)
                .WithSpeedRotation(7200)
                .WithPower(7)
                .Build(),
            new HddBuilder()
                .WithCapacity(256)
                .WithSpeedRotation(5400)
                .WithPower(5)
                .Build(),
            new HddBuilder()
                .WithCapacity(128)
                .WithSpeedRotation(5400)
                .WithPower(6)
                .Build(),
        };
    }

    public HddRepo(IList<Hdd> hdds)
    {
        _hdds = new List<Hdd>(hdds);
    }

    public HddRepo Add(Hdd hdd)
    {
        if (!RepoValidator.IsValidHdd(hdd))
            return new HddRepo();

        _hdds.Add(hdd);

        return this;
    }

    public bool Update(Hdd hdd, Hdd newHdd)
    {
        if (_hdds.IndexOf(hdd) == -1)
            return false;

        _hdds[_hdds.IndexOf(hdd)] = newHdd;

        return true;
    }

    public bool Delete(Hdd hdd)
    {
        return _hdds.Remove(hdd);
    }

    public IList<Hdd>? FindAll(Predicate<Hdd> predicate) => _hdds.FindAll(predicate);
}