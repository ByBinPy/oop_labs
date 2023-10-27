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

    public WiFiAdapterRepo(IList<WiFiAdapter> wifiAdapters)
    {
        _wiFiAdapters = new List<WiFiAdapter>(wifiAdapters);
    }

    public WiFiAdapterRepo AddAdapter(WiFiAdapter wifiAdapter)
    {
        if (!RepoValidator.IsValidWiFiAdapter(wifiAdapter))
            return new WiFiAdapterRepo();

        _wiFiAdapters.Add(wifiAdapter);

        return this;
    }

    public bool Update(WiFiAdapter wifiAdapter, WiFiAdapter newWiFiAdapter)
    {
        if (_wiFiAdapters.IndexOf(wifiAdapter) == -1)
            return false;

        _wiFiAdapters[_wiFiAdapters.IndexOf(wifiAdapter)] = newWiFiAdapter;

        return true;
    }

    public bool Delete(WiFiAdapter wifiAdapter)
    {
        return _wiFiAdapters.Remove(wifiAdapter);
    }

    public IList<WiFiAdapter>? FindAll(Predicate<WiFiAdapter> predicate) => _wiFiAdapters.FindAll(predicate);
}