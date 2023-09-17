namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DeflectorClass1 : TemplateDeflector
{
    public DeflectorClass1(PhotonicDeflector photonicDeflector, PhotonicDeflector thisPhotonicDeflector)
        : base(photonicDeflector)
    {
        ThisPhotonicDeflector = thisPhotonicDeflector;
    }

    protected new PhotonicDeflector ThisPhotonicDeflector { get; private set; }
    protected new int DamageAsteroids { get; private set; } = 50;
    protected new int DamageMeteorites { get; private set; } = 100;
    protected new int DamageAntimaterFlares { get; private set; } = 100;
    protected new int DamageCosmoWhales { get; private set; } = 100;

    public new void IsAlive()
    {
        base.IsAlive();
    }

    public new void Damage(Obstacles obstacle)
    {
        base.Damage(obstacle);
    }
}