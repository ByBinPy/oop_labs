using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Avgur : IShip
{
    public Avgur()
    {
        InstalledDeflector = new DeflectorClassThree();
        InstalledHull = new HullThree(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineE();
        InstalledJumpEngine = new JumpEngineAlpha();
        IsAntinitrineEmitterInstalled = false;
    }

    public Avgur(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClassThree(photonicDeflector);
        InstalledHull = new HullThree(InstalledDeflector);
    }

    public IDeflector? InstalledDeflector { get; private set; }
    public IHull? InstalledHull { get; private set; }
    public IEngine InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
}