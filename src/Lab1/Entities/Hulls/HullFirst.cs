namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class HullFirst : Hull
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double AsteroidDamage = 99;
    private const double MeteorDamage = 100;
    private const double CosmoWhaleDamage = 100;
    public HullFirst()
    {
        InstalledDeflector = Disable;
        HealthPoints = DefaultHealth;
        DamageAsteroid = AsteroidDamage;
        DamageMeteor = MeteorDamage;
        DamageCosmoWhale = CosmoWhaleDamage;
        DamageAntimaterFlare = DeathPoint;
    }

    public HullFirst(Deflector deflector)
        : this()
    {
        InstalledDeflector = deflector;
    }

    public override double HealthPoints { get; protected set; }
    public override Deflector? InstalledDeflector { get; }
    public override double DamageAsteroid { get; }
    public override double DamageMeteor { get; }
    public override double DamageCosmoWhale { get; }
    public override double DamageAntimaterFlare { get; }

    public override bool IsAlive()
    {
        return HealthPoints > DeathPoint;
    }
}