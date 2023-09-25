using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class Avgur : IShip
{
    public Avgur()
    {
        InstalledDeflector = new DeflectorClass3();
        InstalledHull = new Hull3(InstalledDeflector);
        InstalledPulseEngine = new PulseEngineE();
        InstalledJumpEngine = new JumpEngineAlpha();
        IsAntinitrineEmitterInstalled = false;
        Description = "Research ship";
    }

    public Avgur(PhotonicDeflector photonicDeflector)
        : this()
    {
        InstalledDeflector = new DeflectorClass3(photonicDeflector);
        InstalledHull = new Hull3(InstalledDeflector);
    }

    public Deflector? InstalledDeflector { get; private set; }
    public Hull? InstalledHull { get; private set; }
    public IEngine? InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
    public string? Description { get; private set; }
}