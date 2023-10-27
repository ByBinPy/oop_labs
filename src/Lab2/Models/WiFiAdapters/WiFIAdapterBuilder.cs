using System;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;

public class WiFiAdapterBuilder : IWiFiAdapterBuilder
{
    private WiFiStandard? _wiFiStandard;
    private bool _bluetoothUnit;
    private string? _pciEVersion;
    private int _power;
    public WiFiAdapterBuilder() { }

    public WiFiAdapterBuilder(WiFiAdapter wiFiAdapter)
    {
        if (wiFiAdapter == null)
            return;

        _wiFiStandard = wiFiAdapter.WiFiStandard;
        _bluetoothUnit = wiFiAdapter.BluetoothUnit;
        _pciEVersion = wiFiAdapter.PciEVersion;
        _power = wiFiAdapter.Power;
    }

    public IWiFiAdapterBuilder WithWiFiStandard(WiFiStandard wiFiStandard)
    {
        _wiFiStandard = wiFiStandard;
        return this;
    }

    public IWiFiAdapterBuilder WithBluetoothUnit(bool bluetoothUnit)
    {
        _bluetoothUnit = bluetoothUnit;
        return this;
    }

    public IWiFiAdapterBuilder WithPciEVersion(string pciEVersion)
    {
        _pciEVersion = pciEVersion;
        return this;
    }

    public IWiFiAdapterBuilder WithPower(int power)
    {
        _power = power;
        return this;
    }

    public WiFiAdapter Build()
    {
        return new WiFiAdapter(
            _wiFiStandard ?? throw new ArgumentNullException(),
            _bluetoothUnit,
            _pciEVersion ?? throw new ArgumentNullException(),
            _power);
    }
}