using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Xunit;

namespace Lab1.Tests;

public class Test1
{
    [Fact]
    public void TestDeflector1()
    {
        var testingPhotonicDeflector = new PhotonicDeflector();
        var testingDeflectorClass1 = new DeflectorClass1(testingPhotonicDeflector);
        Obstacles testingObstacle = Obstacles.Asteroids;
        testingDeflectorClass1.Damage(testingObstacle);
        Assert.True(testingDeflectorClass1.IsAlive());
    }

    [Fact]
    public void TestDeflector2()
    {
    }
}