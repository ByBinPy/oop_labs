using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Stella : IShip
{
    public Stella()
    {
        InstalledDeflector = new DeflectorClass1();
        InstalledHull = new Hull1(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineC();
        InstalledJumpEngine = new JumpEngineOmega();
        IsAntinitrineEmitterInstalled = false;
        Description = "Stella";
    }

    public Stella(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClass1(photonicDeflector);
        InstalledHull = new Hull1(InstalledDeflector);
    }

    public IDeflector? InstalledDeflector { get; private set; }
    public IHull? InstalledHull { get; private set; }
    public IEngine? InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
    public string? Description { get; private set; }
}