using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;

public class WiFiAdapter
{
    public WiFiAdapter(WiFiStandard wiFiStandard, bool bluetoothUnit, string pciEVersion, int power)
    {
        WiFiStandard = wiFiStandard;
        BluetoothUnit = bluetoothUnit;
        PciEVersion = pciEVersion;
        Power = power;
    }

    public WiFiStandard WiFiStandard { get; }
    public bool BluetoothUnit { get; }
    public string PciEVersion { get; }
    public int Power { get; }
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (WiFiAdapter)obj;

        return WiFiStandard.Version == other.WiFiStandard.Version &&
               BluetoothUnit == other.BluetoothUnit &&
               PciEVersion == other.PciEVersion &&
               Power == other.Power;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WiFiStandard, BluetoothUnit, PciEVersion, Power);
    }
}