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

    public IDeflector? InstalledDeflector { get;  }
    public IHull? InstalledHull { get;  }
    public IEngine InstalledPulseEngine { get;  }
    public IEngine? InstalledJumpEngine { get;  }
    public bool IsAntinitrineEmitterInstalled { get;  }
}