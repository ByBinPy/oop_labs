namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DeflectorClass1 : Deflector
{
    public DeflectorClass1()
    {
        DamageAsteroids = 50 * Hp;
        DamageMeteorites = 100 * Hp;
        DamageCosmoWhales = 100 * Hp;
        InstalledPhotonicDeflector = Disable;
    }

    public DeflectorClass1(PhotonicDeflector photonicDeflector)
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    protected override int DamageAsteroids { get; set; }
    protected override int DamageMeteorites { get;  set; }
    protected override int DamageCosmoWhales { get;  set; }
    protected override PhotonicDeflector? InstalledPhotonicDeflector { get; set; }

    protected override int HitPoints { get; set; } = 100 * Hp;

    public override bool IsAlive()
    {
        return base.IsAlive();
    }

    public override void Damage(Obstacles obstacle)
    {
        if (IsAlive())
                base.Damage(obstacle);
    }
}