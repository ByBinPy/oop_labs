using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class PleasureShuttle : IShip
{
    public PleasureShuttle()
    {
        InstalledDeflector = null;
        InstalledHull = new Hull1();
        InstalledPulseEngine = new PulseEngineC();
        InstalledJumpEngine = null;
        IsAntinitrineEmitterInstalled = false;
        Description = "PleasureShuttle";
    }

    public Deflector? InstalledDeflector { get; private set; }
    public Hull? InstalledHull { get; private set; }
    public IEngine? InstalledPulseEngine { get; private set; }
    public IEngine? InstalledJumpEngine { get; private set; }
    public bool IsAntinitrineEmitterInstalled { get; private set; }
    public string? Description { get; private set; }
}