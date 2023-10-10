using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Xunit;

namespace Lab1.Tests;

public class Test1
{
    public static IEnumerable<object[]> GetDataCase1()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(new Collection<IObstacle>()), 500) }, new Avgur(), new Message(Message.LackRangeMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(new Collection<IObstacle>()), 500) }, new PleasureShuttle(), new Message(Message.LackRangeMessage) };
    }

    public static IEnumerable<object[]> GetDataCase2()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new AntimaterFlare() }), 201) }, new Vaclas(new PhotonicDeflector()), new Message() };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new AntimaterFlare() }), 201) }, new Vaclas(), new Message(Message.DiedMessage) };
    }

    public static IEnumerable<object[]> GetDataCase3()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale(), new CosmoWhale() }), 100) }, new Vaclas(), new Message(Message.CrashMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale(), new CosmoWhale() }), 100) }, new Avgur(), new Message() };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale(), new CosmoWhale() }), 100) }, new Meridian(), new Message() };
    }

    public static IEnumerable<object[]> GetDataStudentCase()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200), new RouteCut(new Space(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid(), new Asteroid(), new Meteor(), new Meteor() })), new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new AntimaterFlare() }), 500) }, new Vaclas(new PhotonicDeflector()), new Message(Message.DiedMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200), new RouteCut(new Space(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid(), new Asteroid(), new Meteor(), new Meteor() })), new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new AntimaterFlare() }), 500) }, new Avgur(new PhotonicDeflector()), new Message(Message.LackRangeMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200), new RouteCut(new Space(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid(), new Asteroid(), new Meteor(), new Meteor() })), new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new AntimaterFlare() }), 500) }, new Stella(new PhotonicDeflector()), new Message(Message.DiedMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200), new RouteCut(new Space(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid(), new Asteroid(), new Meteor(), new Meteor() })), new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid() }), 200) }, new Vaclas(), new Message() };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200), new RouteCut(new Space(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid(), new Asteroid(), new Meteor(), new Meteor() })), new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid() }), 200) }, new Avgur(), new Message() };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200), new RouteCut(new Space(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid(), new Asteroid(), new Meteor(), new Meteor() })), new RouteCut(new HighDensityNebula(new Collection<IObstacle> { new Asteroid(), new Asteroid(), new Asteroid() }), 200) }, new Stella(), new Message(Message.CrashMessage) };
    }

    [Theory]
    [MemberData(nameof(GetDataCase1))]
    private void TheoryLooseTestAvgurPleassureCase1(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }

    [Theory]
    [MemberData(nameof(GetDataCase2))]
    private void TheoryTestVaclasFlareCase2(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }

    [Theory]
    [MemberData(nameof(GetDataCase3))]
    private void TheoryTestThreeShipsCase3(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }

    [Fact]
    private void FactTestPleassureAvgurCase4()
    {
        var testShipSelector = new ShipSelector(new Collection<Analyzer> { new Analyzer(new Collection<RouteCut> { new RouteCut(new Space(new Collection<IObstacle> { }), 100) }, new Vaclas()), new Analyzer(new Collection<RouteCut> { new RouteCut(new Space(new Collection<IObstacle> { }), 100) }, new PleasureShuttle()) });
        Assert.True(testShipSelector.Selector() is PleasureShuttle);
    }

    [Fact]
    private void FactTestAvgurStellaCase5()
    {
        var testShipSelector = new ShipSelector(new Collection<Analyzer> { new Analyzer(new Collection<RouteCut> { new RouteCut(new HighDensityNebula(new Collection<IObstacle> { }), 505) }, new Avgur()), new Analyzer(new Collection<RouteCut> { new RouteCut(new HighDensityNebula(new Collection<IObstacle> { }), 505) }, new Stella()) });
        Assert.True(testShipSelector.Selector() is Stella);
    }

    [Fact]
    private void FactTestPleassureVaclasCase6()
    {
        var testShipSelector = new ShipSelector(new Collection<Analyzer> { new Analyzer(new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200) }, new Vaclas()), new Analyzer(new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(new Collection<IObstacle> { new CosmoWhale() }), 200) }, new PleasureShuttle()) });
        Assert.True(testShipSelector.Selector() is Vaclas);
    }

    [Theory]
    [MemberData(nameof(GetDataStudentCase))]
    private void TheoryStudentCase(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }
}
