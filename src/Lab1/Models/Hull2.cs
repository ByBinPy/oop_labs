namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class Hull2 : Hull
{
    public Hull2()
    {
        DamageAsteroids = 20 * Hp;
        DamageMeteorites = 50 * Hp;
        DamageCosmoWhales = 100 * Hp;
        IntalledDiflector = Disable;
    }

    protected override int DamageAsteroids { get; set; }
    protected override int DamageMeteorites { get; set; }
    protected override int DamageCosmoWhales { get; set; }
    protected override int HitPoints { get; set; }
    protected override Deflector? IntalledDiflector { get; set; }
    public override bool IsAlive()
    {
        return base.IsAlive();
    }

    public override void Damage(Obstacles obstacle)
    {
        base.Damage(obstacle);
    }
}