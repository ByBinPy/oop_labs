namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClass3 : Deflector
{
    public DeflectorClass3()
    {
        DamageAsteroids = 4 * Hp;
        DamageMeteorites = 40 * Hp;
        DamageCosmoWhales = 160 * Hp;
        HitPoints = 100 * Hp;
        InstalledPhotonicDeflector = Disable;
    }

    public DeflectorClass3(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    protected override int DamageAsteroids { get; set; }
    protected override int DamageMeteorites { get;  set; }
    protected override int DamageCosmoWhales { get;  set; }
    protected override PhotonicDeflector? InstalledPhotonicDeflector { get; set; }
    protected override int HitPoints { get; set; }
    public override bool IsAlive()
    {
        return base.IsAlive();
    }

    public override void Damage(Obstacles obstacle)
    {
        base.Damage(obstacle);
    }
}