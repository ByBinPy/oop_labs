using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Connectors;
using Itmo.ObjectOrientedProgramming.Lab2.Ssds;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class SsdRepo
{
    private readonly List<Ssd> _ssds;

    public SsdRepo()
    {
        _ssds = new List<Ssd>()
        {
            new SsdBuilder()
                .WithCapacity(128)
                .WithConnection(new Connector("SATA"))
                .WithPower(50)
                .WithMaxSpeed(2900)
                .Build(),
            new SsdBuilder()
                .WithCapacity(256)
                .WithConnection(new Connector("SATA"))
                .WithPower(55)
                .WithMaxSpeed(3000)
                .Build(),
            new SsdBuilder()
                .WithCapacity(512)
                .WithConnection(new Connector("SATA"))
                .WithPower(60)
                .WithMaxSpeed(3100)
                .Build(),
            new SsdBuilder()
                .WithCapacity(1024)
                .WithConnection(new Connector("SATA"))
                .WithPower(75)
                .WithMaxSpeed(3150)
                .Build(),
        };
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