using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class WiFiAdapterRepo
{
    private readonly List<WiFiAdapter> _wiFiAdapters;

    public WiFiAdapterRepo()
    {
        _wiFiAdapters = new List<WiFiAdapter>()
        {
        };
    }

    public WiFiAdapterRepo(IList<WiFiAdapter> dds)
    {
        _wiFiAdapters = new List<WiFiAdapter>(dds);
    }

    public WiFiAdapterRepo Add(WiFiAdapter dd)
    {
        if (!RepoValidator.IsValidWiFiAdapter(dd))
            return new WiFiAdapterRepo();

        _wiFiAdapters.Add(dd);

        return this;
    }

    public bool Update(WiFiAdapter dd, WiFiAdapter newWiFiAdapter)
    {
        if (_wiFiAdapters.IndexOf(dd) == -1)
            return false;

        _wiFiAdapters[_wiFiAdapters.IndexOf(dd)] = newWiFiAdapter;

        return true;
    }

    public bool Delete(WiFiAdapter dd)
    {
        return _wiFiAdapters.Remove(dd);
    }

    public IList<WiFiAdapter>? FindAll(Predicate<WiFiAdapter> predicate) => _wiFiAdapters.FindAll(predicate);
}