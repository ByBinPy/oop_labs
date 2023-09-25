namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public interface IDeflector
{
    // null constant - show consist of Photonic diflector
    protected const PhotonicDeflector? Disable = null;
    protected const int Hp = 1;
    protected const int DeathPoint = 0;
    int DamageAsteroids { get; }
    int DamageMeteorites { get; }
    int DamageCosmoWhales { get; }
    PhotonicDeflector? InstalledPhotonicDeflector { get; }
    int HitPoints { get; }

    public bool ExistencePhotonicDeflector();

    public bool IsAlive();

    public void Damage(Obstacles obstacle);
}