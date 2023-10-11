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

    public Deflector? InstalledDeflector { get;  }
    public IHull? InstalledHull { get;  }
    public IEngine InstalledPulseEngine { get;  }
    public IEngine? InstalledJumpEngine { get;  }
    public bool IsAntinitrineEmitterInstalled { get;  }
}