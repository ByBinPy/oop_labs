using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Avgur : IShip
{
    public Avgur()
    {
        InstalledDeflector = new DeflectorClassThird();
        InstalledHull = new HullThird(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineE();
        InstalledJumpEngine = new JumpEngineAlpha();
        IsAntinitrineEmitterInstalled = false;
    }

    public Avgur(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClassThird(photonicDeflector);
        InstalledHull = new HullThird(InstalledDeflector);
    }

    public IDeflector? InstalledDeflector { get; }
    public IHull? InstalledHull { get; }
    public IEngine InstalledPulseEngine { get; }
    public IEngine? InstalledJumpEngine { get; }
    public bool IsAntinitrineEmitterInstalled { get; }
}