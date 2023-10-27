namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

public interface IWiFiAdapterBuilder
{
    /*WiFiStandard = wiFiStandard;
    BluetoothUnit = bluetoothUnit;
    PciEVersion = pciEVersion;
    Power = power;*/
    IWiFiAdapterBuilder WithWiFiStandard(WiFiStandard wiFiStandard);
    IWiFiAdapterBuilder WithBluetoothUnit(bool bluetoothUnit);
    IWiFiAdapterBuilder WithPciEVersion(string pciEVersion);
    IWiFiAdapterBuilder WithPower(int power);
    WiFiAdapter Build();
}