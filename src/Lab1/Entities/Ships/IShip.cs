using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public interface IShip
{
    Deflector? InstalledDeflector { get; }
    IHull? InstalledHull { get; }
    IEngine InstalledPulseEngine { get; }
    IEngine? InstalledJumpEngine { get; }
    bool IsAntinitrineEmitterInstalled { get; }
}