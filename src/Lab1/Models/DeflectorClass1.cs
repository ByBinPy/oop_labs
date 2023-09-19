namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DeflectorClass1 : Deflector
{
    public DeflectorClass1(PhotonicDeflector photonicDeflector)
    {
        ThisPhotonicDeflector = photonicDeflector;
    }

    protected override int DamageAsteroids { get; set; } = 50 * Hp;
    protected override int DamageMeteorites { get;  set; } = 100 * Hp;
    protected override int DamageAntimaterFlares { get;  set; } = 100 * Hp;
    protected override int DamageCosmoWhales { get;  set; } = 100 * Hp;
    protected override PhotonicDeflector? ThisPhotonicDeflector { get; set; } = Disable;

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