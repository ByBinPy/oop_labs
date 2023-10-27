using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Hdds;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class HddRepo
{
    private readonly List<Hdd> _hdds;

    /*
        Capacity = capacity;
        SpedRotation = spedRotation;
        Power = power;
     */
    public HddRepo()
    {
        _hdds = new List<Hdd>()
        {
            new HddBuilder().WithCapacity(512).WithSpeedRotation(7200).WithPower(7).Build(),
            new HddBuilder().WithCapacity(256).WithSpeedRotation(5400).WithPower(5).Build(),
            new HddBuilder().WithCapacity(128).WithSpeedRotation(5400).WithPower(6).Build(),
        };
    }

    public HddRepo(IList<Hdd> dds)
    {
        _hdds = new List<Hdd>(dds);
    }

    public HddRepo Add(Hdd dd)
    {
        if (!RepoValidator.IsValidHdd(dd))
            return new HddRepo();

        _hdds.Add(dd);

        return this;
    }

    public bool Update(Hdd dd, Hdd newHdd)
    {
        if (_hdds.IndexOf(dd) == -1)
            return false;

        _hdds[_hdds.IndexOf(dd)] = newHdd;

        return true;
    }

    public bool Delete(Hdd dd)
    {
        return _hdds.Remove(dd);
    }

    public IList<Hdd>? FindAll(Predicate<Hdd> predicate) => _hdds.FindAll(predicate);
}