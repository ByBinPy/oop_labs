using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
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

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { false } };

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
    public static IEnumerable<object[]> GetDataDeflector3WithPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, true } };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 40).ToArray(), new PhotonicDeflector(), Enumerable.Repeat(true, 39).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Meteorites, 10).ToArray(), new PhotonicDeflector(), Enumerable.Repeat(true, 9).Append(false).ToArray() };

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites, Obstacles.Meteorites, Obstacles.Meteorites }, new PhotonicDeflector(), new bool[] { true, true, true } };

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

        yield return new object[] { new Obstacles[] { Obstacles.Meteorites }, new bool[] { false } };

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
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataDeflector3WithoutPhotonicDeflector()
    {
        yield return new object[] { new Obstacles[] { Obstacles.Asteroids, Obstacles.Meteorites }, new bool[] { true, true } };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 40).ToArray(), Enumerable.Repeat(true, 39).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Meteorites, 10).ToArray(), Enumerable.Repeat(true, 9).Append(false).ToArray() };

        yield return new object[] { new Obstacles[] { Obstacles.AntimaterFlares }, new bool[] { false } };
    }
#pragma warning restore CA1024
#pragma warning disable CA1024
    public static IEnumerable<object[]> GetDataHull1WithDeflector()
    {
// testing asteroids
        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 4), new DeflectorClass1(), Enumerable.Repeat(true, 3).Append(false) };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 12).ToArray(), new DeflectorClass2(), Enumerable.Repeat(true, 11).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 42).ToArray(), new DeflectorClass3(), Enumerable.Repeat(true, 41).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 1).Concat(Enumerable.Repeat(Obstacles.AntimaterFlares, 3)).Concat(Enumerable.Repeat(Obstacles.Asteroids, 3)).ToArray(), new DeflectorClass1(new PhotonicDeflector()), Enumerable.Repeat(true, 6).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 9).Concat(Enumerable.Repeat(Obstacles.AntimaterFlares, 3)).Concat(Enumerable.Repeat(Obstacles.Asteroids, 3)).ToArray(), new DeflectorClass2(new PhotonicDeflector()), Enumerable.Repeat(true, 14).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Asteroids, 39).Concat(Enumerable.Repeat(Obstacles.AntimaterFlares, 3)).Concat(Enumerable.Repeat(Obstacles.Asteroids, 3)).ToArray(), new DeflectorClass3(new PhotonicDeflector()), Enumerable.Repeat(true, 44).Append(false).ToArray() };

// testing meteorites
        yield return new object[] { Enumerable.Repeat(Obstacles.Meteorites, 2).ToArray(), new DeflectorClass1(), Enumerable.Repeat(true, 1).Append(false) };

        yield return new object[] { Enumerable.Repeat(Obstacles.Meteorites, 4).ToArray(), new DeflectorClass2(), Enumerable.Repeat(true, 3).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Meteorites, 11).ToArray(), new DeflectorClass3(), Enumerable.Repeat(true, 10).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Meteorites, 2).Concat(Enumerable.Repeat(Obstacles.AntimaterFlares, 3)).Append(Obstacles.Meteorites).Append(Obstacles.Meteorites).ToArray(), new DeflectorClass2(new PhotonicDeflector()), Enumerable.Repeat(true, 6).Append(false).ToArray() };

        yield return new object[] { Enumerable.Repeat(Obstacles.Meteorites, 9).Concat(Enumerable.Repeat(Obstacles.AntimaterFlares, 3)).Append(Obstacles.Meteorites).Append(Obstacles.Meteorites).ToArray(), new DeflectorClass3(new PhotonicDeflector()), Enumerable.Repeat(true, 13).Append(false).ToArray() };
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
    [MemberData(nameof(GetDataDeflector3WithPhotonicDeflector))]
    public void TheoryTestDeflector3WithPhotonicDeflector(IEnumerable<Obstacles> obstaclesCollection, PhotonicDeflector testingPhotonicDeflector, IEnumerable<bool> waitingResult)
    {
        var result = new List<bool>();
        var testingDeflectorClass3 = new DeflectorClass3(testingPhotonicDeflector);
        if (obstaclesCollection != null)
        {
            foreach (Obstacles obstacle in obstaclesCollection)
            {
                // Workaround
                testingDeflectorClass3.Damage(obstacle);
                result.Add(testingDeflectorClass3.IsAlive());
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

    [Theory]
    [MemberData(nameof(GetDataDeflector3WithoutPhotonicDeflector))]
    public void TheoryTestDeflector3WithoutPhotonicDeflector(IEnumerable<Obstacles> obstaclesCollection, IEnumerable<bool> waitingResult)
    {
        var result = new List<bool>();
        var testingDeflectorClass3 = new DeflectorClass3();
        if (obstaclesCollection != null)
        {
            foreach (Obstacles obstacle in obstaclesCollection)
            {
                try
                {
                    testingDeflectorClass3.Damage(obstacle);
                    result.Add(testingDeflectorClass3.IsAlive());
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

    [Theory]
    [MemberData(nameof(GetDataHull1WithDeflector))]
    public void TheoryTestHull1WithDeflector(IEnumerable<Obstacles> obstaclesCollection, IDeflector deflector, IEnumerable<bool> waitingResult)
    {
        var result = new List<bool>();
        var testingHull1 = new Hull1(deflector);
        if (obstaclesCollection != null)
        {
            foreach (Obstacles obstacle in obstaclesCollection)
            {
                testingHull1.Damage(obstacle);
                result.Add(testingHull1.IsAlive());
            }
        }

        Assert.Equal(result, waitingResult);
    }

    [Fact]
    public void LabaTestShipSelectorAvgurPleasure()
    {
        var analyzerAvgur = new Analyzer(new Collection<RouteCut>() { new RouteCut(new HighDensityNebula(), 500) }, new Avgur());
        var analyzerPleasure = new Analyzer(new Collection<RouteCut>() { new RouteCut(new HighDensityNebula(), 500) }, new PleasureShuttle());
        var selector = new ShipSelector(analyzerAvgur, analyzerPleasure);
        Assert.Null(selector.Selector());
    }

    [Fact]
    public void LabaTestShipSelectorVaclasVaclasWithPhotonicDefector()
    {
        var analyzerVaclas = new Analyzer(new Collection<RouteCut>() { new RouteCut(new HighDensityNebula(new Collection<Obstacles>() { Obstacles.AntimaterFlares }), 500) }, new Vaclas());
        var analyzerVaclasWithPhotonicDeflector = new Analyzer(new Collection<RouteCut>() { new RouteCut(new HighDensityNebula(new Collection<Obstacles>() { Obstacles.AntimaterFlares }), 500) }, new Vaclas(new PhotonicDeflector()));
        var selector = new ShipSelector(analyzerVaclas, analyzerVaclasWithPhotonicDeflector);
        Assert.True(selector.Selector() == "second");
    }
    public void LabTestShipSelectorVaclas
}