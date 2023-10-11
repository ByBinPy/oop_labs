namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public sealed class DeflectorClassThird : Deflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double AsteroidDamage = 2.5;
    private const double MeteorDamage = 10;
    private const double CosmoWhaleDamage = 90;
    public DeflectorClassThird()
    {
        InstalledPhotonicDeflector = Disable;
        HealthPoints = DefaultHealth;
        DamageAsteroid = AsteroidDamage;
        DamageMeteor = MeteorDamage;
        DamageCosmoWhale = CosmoWhaleDamage;
        DamageAntimaterFlare = DeathPoint;
    }

    public DeflectorClassThird(PhotonicDeflector? photonicDeflector)
        : this()
    {
        InstalledPhotonicDeflector = photonicDeflector;
    }

    public override double HealthPoints { get; protected set; }
    public override PhotonicDeflector? InstalledPhotonicDeflector { get; }
    public override double DamageAsteroid { get; }
    public override double DamageMeteor { get; }
    public override double DamageCosmoWhale { get; }
    public override double DamageAntimaterFlare { get; }

    public override bool IsAlive()
    {
        return HealthPoints > DeathPoint;
    }
}