using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

public class PleasureShuttle : IShip
{
    public PleasureShuttle()
    {
        InstalledDeflector = null;
        InstalledHull = new HullFirst();
        InstalledPulseEngine = new PulseEngineC();
        InstalledJumpEngine = null;
        IsAntinitrineEmitterInstalled = false;
    }

    public IDeflector? InstalledDeflector { get;  }
    public IHull? InstalledHull { get;  }
    public IEngine InstalledPulseEngine { get;  }
    public IEngine? InstalledJumpEngine { get;  }
    public bool IsAntinitrineEmitterInstalled { get;  }
    public string? Description { get;  }
}