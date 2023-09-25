using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Meridian : IShip
{
    public Meridian()
    {
        InstalledDeflector = new DeflectorClass2();
        InstalledHull = new Hull2(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineE();
        InstalledJumpEngine = null;
        IsAntinitrineEmitterInstalled = true;
        Description = "Mining ship";
    }

    public Meridian(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClass2(photonicDeflector);
        InstalledHull = new Hull2(InstalledDeflector);
    }

    public Deflector? InstalledDeflector { get; private set; }
    public Hull? InstalledHull { get; private set; }
    public IEngine? InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
    public string? Description { get; private set; }
}