using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public interface IShip
{
    Deflector? InstalledDeflector { get; }
    Hull? InstalledHull { get; }
    IEngine? InstalledPulseEngine { get; }
    IEngine? InstalledJumpEngine { get; }
    WieghtDimensional WeightCharacteristic { get; }
    bool IsAntinitrineEmitterInstalled { get; }
    string? Description { get; }
}