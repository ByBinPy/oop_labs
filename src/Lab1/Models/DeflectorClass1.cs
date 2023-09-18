namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DeflectorClass1 : TemplateDeflector
{
    private int _hitPoints = TemplateDeflector.InitialHitPoints;

    public DeflectorClass1(PhotonicDeflector photonicDeflector)
    {
        ThisPhotonicDeflector = photonicDeflector;
    }

    protected int DamageAsteroids { get; private set; } = 50;
    protected int DamageMeteorites { get; private set; } = 100;
    protected int DamageAntimaterFlares { get; private set; } = 100;
    protected int DamageCosmoWhales { get; private set; } = 100;
    protected PhotonicDeflector? ThisPhotonicDeflector { get; private set; }

    protected int HitPoints
    {
        get => _hitPoints;
        private set => _hitPoints = value;
    }

    public bool IsAlive()
    {
        return _hitPoints > TemplateDeflector.Death;
    }

    public void Damage(Obstacles obstacle)
    {
        if (IsAlive())
                Damage(obstacle, ref _hitPoints, DamageAsteroids, DamageMeteorites, DamageAntimaterFlares, DamageCosmoWhales, ThisPhotonicDeflector);
    }
}