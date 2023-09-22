namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClass2 : Deflector
{
    public DeflectorClass2()
    {
        DamageAsteroids = 10 * Hp;
        DamageMeteorites = 34 * Hp;
        DamageCosmoWhales = 100 * Hp;
        HitPoints = 100 * Hp;
        InstalledPhotonicDeflector = Disable;
    }

    public DeflectorClass2(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    protected override int DamageAsteroids { get; set; }
    protected override int DamageMeteorites { get; set; }
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