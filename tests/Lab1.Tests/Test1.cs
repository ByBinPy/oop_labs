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

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares }, new PhotonicDeflector(), new bool[] { true } };

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares, Obstacles.AntimaterFlares, Obstacles.AntimaterFlares }, new PhotonicDeflector(), new bool[] { true, true, true } };
    }
#pragma warning restore CA1024
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector2WithPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, true } };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 10).ToArray(), new PhotonicDeflector(), Enumerable.Repeat(true, 9).Append(false).ToArray() };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares }, new PhotonicDeflector(), new bool[] { true } };

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares, Obstacles.AntimaterFlares, Obstacles.AntimaterFlares }, new PhotonicDeflector(), new bool[] { true, true, true } };
    }
#pragma warning restore CA1024
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector1WithoutPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Asteroids }, new bool[] { true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites }, new bool[] { false, false } };

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares }, new bool[] { false } };

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares, Obstacles.AntimaterFlares, Obstacles.AntimaterFlares }, new bool[] { false, false, false } };
    }
#pragma warning restore CA1024
    // Rider think that property but that method
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector2WithoutPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new bool[] { true, true } };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 10).ToArray(), Enumerable.Repeat(true, 9).Append(false).ToArray() };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites, Obstacles.Meteorites }, new bool[] { true, true, false } };

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares }, new bool[] { false } };
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
        var testingDeflectorClass2 = new DeflectorClass2(testingPhotonicDeflector);
        if (obstaclesCollection != null)
        {
            foreach (Obstacles obstacle in obstaclesCollection)
            {
                // Workaround
                testingDeflectorClass2.Damage(obstacle);
                result.Add(testingDeflectorClass2.IsAlive());
            }
        }

        Assert.Equal(result, waitingResult);
    }

    [Theory]
    [MemberData(nameof(GetDataDeflector1WithoutPhotonicDeflector))]
    public void TheoryTestDeflector1WithoutPhotonicDeflector(IEnumerable<Obstacles> obstaclesCollection, IEnumerable<bool> waitingResult)
    {
        var result = new List<bool>();
        var testingDeflectorClass1 = new DeflectorClass1();
        if (obstaclesCollection != null)
        {
            foreach (Obstacles obstacle in obstaclesCollection)
            {
                // Workaround
                try
                {
                    testingDeflectorClass1.Damage(obstacle);
                    result.Add(testingDeflectorClass1.IsAlive());
                }
                catch (AggregateException)
                {
                    result.Add(false);
                }
            }
        }

        Assert.Equal(result, waitingResult);
    }

    [Theory]
    [MemberData(nameof(GetDataDeflector2WithoutPhotonicDeflector))]
    public void TheoryTestDeflector2WithoutPhotonicDeflector(IEnumerable<Obstacles> obstaclesCollection, IEnumerable<bool> waitingResult)
    {
        var result = new List<bool>();
        var testingDeflectorClass2 = new DeflectorClass2();
        if (obstaclesCollection != null)
        {
            foreach (Obstacles obstacle in obstaclesCollection)
            {
                try
                {
                    testingDeflectorClass2.Damage(obstacle);
                    result.Add(testingDeflectorClass2.IsAlive());
                }
                catch (AggregateException)
                {
                    result.Add(false);
                }

                // Workaround
            }
        }

        Assert.Equal(result, waitingResult);
    }
}