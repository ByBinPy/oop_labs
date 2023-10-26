namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

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
}