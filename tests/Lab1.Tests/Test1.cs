using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Xunit;

namespace Lab1.Tests;

public class Test1
{
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector1WithPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Asteroids }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { false, false } };
        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares }, new bool[] { false } };
    }
#pragma warning restore CA1024
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector2WithPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Asteroids }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { false, false } };
    }
#pragma warning restore CA1024
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector1WithoutPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Asteroids }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { false, false } };
        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares }, new bool[] { false } };
    }
#pragma warning restore CA1024
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector2WithoutPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Asteroids }, new PhotonicDeflector(), new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { false, false } };
    }
#pragma warning restore CA1024
    [Theory]
    [MemberData(nameof(GetDataDeflector1WithPhotonicDeflector))]
    public void TheoryTestDeflector1WithPhotonicDeflector(IEnumerable<Obstacles> obstaclesCollection, PhotonicDeflector? testingPhotonicDeflector, IEnumerable<bool> waitingResult)
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

    [Theory]
    [MemberData(nameof(GetDataDeflector2WithPhotonicDeflector))]
    public void TheoryTestDeflector2WithPhotonicDeflector(IEnumerable<Obstacles> obstaclesCollection, PhotonicDeflector testingPhotonicDeflector, IEnumerable<bool> waitingResult)
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
    [Theory]
    [MemberData(nameof(GetDataDeflector1WithoutPhotonicDeflector))]
    public void TheoryTestDeflector1(IEnumerable<Obstacles> obstaclesCollection, PhotonicDeflector? testingPhotonicDeflector, IEnumerable<bool> waitingResult)
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

    [Theory]
    [MemberData(nameof(GetDataDeflector2WithoutPhotonicDeflector))]
    public void TheoryTestDeflector2WithoutPhotonicDeflector(IEnumerable<Obstacles> obstaclesCollection, PhotonicDeflector testingPhotonicDeflector, IEnumerable<bool> waitingResult)
    {
        var result = new List<bool>();
        var testingDeflectorClass1 = new DeflectorClass1();
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