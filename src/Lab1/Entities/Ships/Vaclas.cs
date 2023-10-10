using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Vaclas : IShip
{
    public Vaclas()
    {
        InstalledDeflector = new DeflectorClassFirst();
        InstalledHull = new HullSecond(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineE();
        InstalledJumpEngine = new JumpEngineGamma();
        IsAntinitrineEmitterInstalled = false;
    }

    public Vaclas(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClassFirst(photonicDeflector);
        InstalledHull = new HullSecond(InstalledDeflector);
    }

    public IDeflector? InstalledDeflector { get; private set; }
    public IHull? InstalledHull { get; private set; }
    public IEngine InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
}