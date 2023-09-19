namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DeflectorClass3 : Deflector
{
    public DeflectorClass3(PhotonicDeflector photonicDeflector)
    {
        ThisPhotonicDeflector = photonicDeflector;
    }

    protected override int DamageAsteroids { get; set; } = 4 * Hp;
    protected override int DamageMeteorites { get;  set; } = 40 * Hp;
    protected override int DamageAntimaterFlares { get;  set; } = 160 * Hp;
    protected override int DamageCosmoWhales { get;  set; } = 160 * Hp;
    protected override PhotonicDeflector? ThisPhotonicDeflector { get; set; } = Disable;
    protected override int HitPoints { get; set; } = 160 * Hp;
    public override bool IsAlive()
    {
        return base.IsAlive();
    }

    public override void Damage(Obstacles obstacle)
    {
        base.Damage(obstacle);
    }
}