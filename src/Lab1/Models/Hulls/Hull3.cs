namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class Hull3 : Hull
{
    public Hull3()
    {
        DamageAsteroids = 5 * Hp;
        DamageMeteorites = 20 * Hp;
        DamageCosmoWhales = 100 * Hp;
        HitPoints = 100 * Hp;
        IntalledDiflector = Disable;
    }

    public Hull3(Deflector deflector)
        : this()
    {
        IntalledDiflector = deflector;
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