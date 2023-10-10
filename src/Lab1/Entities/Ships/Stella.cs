using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Stella : IShip
{
    public Stella()
    {
        InstalledDeflector = new DeflectorClassFirst();
        InstalledHull = new HullFirst(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineC();
        InstalledJumpEngine = new JumpEngineOmega();
        IsAntinitrineEmitterInstalled = false;
    }

    public Stella(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClassFirst(photonicDeflector);
        InstalledHull = new HullFirst(InstalledDeflector);
    }

    public IDeflector? InstalledDeflector { get; private set; }
    public IHull? InstalledHull { get; private set; }
    public IEngine InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
}