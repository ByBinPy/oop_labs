using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Meridian : IShip
{
    public Meridian()
    {
        InstalledDeflector = new DeflectorClassSecond();
        InstalledHull = new HullSecond(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineE();
        InstalledJumpEngine = null;
        IsAntinitrineEmitterInstalled = true;
    }

    public Meridian(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClassSecond(photonicDeflector);
        InstalledHull = new HullSecond(InstalledDeflector);
    }

    public IDeflector? InstalledDeflector { get; private set; }
    public IHull? InstalledHull { get; private set; }
    public IEngine InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
}