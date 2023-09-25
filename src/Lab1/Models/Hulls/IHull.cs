namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IHull
{
    protected const int Hp = 1;
    protected const int DeathPoints = 0;
    protected const IDeflector? Disable = null;
    protected int DamageAsteroids { get;  }
    protected int DamageMeteorites { get;  }
    protected int DamageCosmoWhales { get;  }
    protected int HitPoints { get;  }
    protected IDeflector? IntalledDiflector { get;  }

    public bool IsAlive();

    public void Damage(Obstacles obstacle);
}