using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IHull
{
    protected int DamageAsteroids { get;  }
    protected int DamageMeteors { get;  }
    protected int DamageCosmoWhales { get;  }
    protected int HitPoints { get;  }
    protected IDeflector? InstalledDiflector { get;  }

    public bool IsAlive();

    public Message Damage(IObstacle obstacle);
}