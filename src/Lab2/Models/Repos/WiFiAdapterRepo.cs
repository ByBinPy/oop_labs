using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class WiFiAdapterRepo
{
    private readonly List<WiFiAdapter> _wiFiAdapters;

    public WiFiAdapterRepo()
    {
        _wiFiAdapters = new List<WiFiAdapter>()
        {
            new WiFiAdapterBuilder()
                .WithWiFiStandard(new WiFiStandard("5.0"))
                .WithBluetoothUnit(true)
                .WithPciEVersion("4.0")
                .WithPower(15)
                .Build(),
            new WiFiAdapterBuilder()
                .WithWiFiStandard(new WiFiStandard("4.0"))
                .WithBluetoothUnit(true)
                .WithPciEVersion("3.0")
                .WithPower(11)
                .Build(),
            new WiFiAdapterBuilder()
                .WithWiFiStandard(new WiFiStandard("6.0"))
                .WithBluetoothUnit(true)
                .WithPciEVersion("6.0")
                .WithPower(16)
                .Build(),
            new WiFiAdapterBuilder()
                .WithWiFiStandard(new WiFiStandard("3.0"))
                .WithBluetoothUnit(false)
                .WithPciEVersion("2.0")
                .WithPower(10)
                .Build(),
            new WiFiAdapterBuilder()
                .WithWiFiStandard(new WiFiStandard("4.0"))
                .WithBluetoothUnit(false)
                .WithPciEVersion("5.0")
                .WithPower(13)
                .Build(),
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