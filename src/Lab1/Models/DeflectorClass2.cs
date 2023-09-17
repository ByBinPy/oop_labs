namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DeflectorClass2 : TemplateDeflector
{
    public DeflectorClass2(PhotonicDeflector photonicDeflector)
    : base(photonicDeflector)
    {
        ThisPhotonicDeflector = photonicDeflector;
    }

    protected new PhotonicDeflector ThisPhotonicDeflector { get; private set; }
    protected new int DamageAsteroids { get; private set; } = 10;
    protected new int DamageMeteorites { get; private set; } = 34;
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