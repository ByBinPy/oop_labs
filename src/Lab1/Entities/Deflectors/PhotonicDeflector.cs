using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public sealed class PhotonicDeflector : Deflector
{
    private const PhotonicDeflector? Disable = null;
    private const int DeathPoint = 0;
    private const int DefaultHealth = 100;
    private const double AsteroidDamage = 50;
    private const double MeteorDamage = 100;
    private const double CosmoWhaleDamage = 100;
    public PhotonicDeflector()
    {
        InstalledPhotonicDeflector = Disable;
        HealthPoints = DefaultHealth;
        DamageAsteroid = AsteroidDamage;
        DamageMeteor = MeteorDamage;
        DamageCosmoWhale = CosmoWhaleDamage;
        DamageAntimaterFlare = DeathPoint;
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

    public override Message Damage(IObstacle obstacle)
    {
        if (obstacle is AntimaterFlare)
            HealthPoints -= DamageAntimaterFlare;
        return IsAlive() ? new Message() : new Message(Message.DiedMessage);
    }
}