using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Xunit;

namespace Lab1.Tests;

public class Test1
{
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, false } };
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Asteroids }, new PhotonicDeflector(), new bool[] { true, false } };
        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { false, false } };
    }
#pragma warning restore CA1024
    [Theory]
    [MemberData(nameof(GetData))]
    public void TheoryTestDeflector1(IEnumerable<Obstacles> obstaclesCollection, PhotonicDeflector testingPhotonicDeflector, IEnumerable<bool> waitingResult)
    {
        var result = new List<bool>();
        var testingDeflectorClass1 = new DeflectorClass1(testingPhotonicDeflector);
        if (obstaclesCollection != null)
        {
            foreach (Obstacles obstacle in obstaclesCollection)
            {
                // Workaround
                testingDeflectorClass1.Damage(obstacle);
                result.Add(testingDeflectorClass1.IsAlive());
            }
        }

        Assert.Equal(result, waitingResult);
    }

    [Fact]
    public void FactTestDeflector1()
    {
        var testingPhotonicDeflector = new PhotonicDeflector();
        var testingDeflectorClass1 = new DeflectorClass1(testingPhotonicDeflector);
        Obstacles testingObstacle = Obstacles.Asteroids;
        testingDeflectorClass1.Damage(testingObstacle);
        Assert.True(testingDeflectorClass1.IsAlive());
    }
}