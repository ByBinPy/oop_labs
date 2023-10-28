using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Xunit;

namespace Lab1.Tests;

public class Test1
{
    // this method return data for my theory tests
    public static IEnumerable<object[]> GetDataCase1()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(), 500) }, new Avgur(), new Message(Message.LackRangeMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(), 500) }, new PleasureShuttle(), new Message(Message.LackRangeMessage) };
    }

    public static IEnumerable<object[]> GetDataCase2()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(1), 201) }, new Vaclas(new PhotonicDeflector()), new Message() };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new HighDensityNebula(1), 201) }, new Vaclas(), new Message(Message.DiedMessage) };
    }

    public static IEnumerable<object[]> GetDataCase3()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(2), 100) }, new Vaclas(), new Message(Message.CrashMessage) };
        /*yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(2), 100) }, new Avgur(), new Message() };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(2), 100) }, new Meridian(), new Message() };*/
    }

    public static IEnumerable<object[]> GetDataStudentCase()
    {
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(1), 200), new RouteCut(new Space(4, 2)), new RouteCut(new HighDensityNebula(1), 500) }, new Stella(new PhotonicDeflector()), new Message(Message.CrashMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(1), 200), new RouteCut(new Space(4, 2)), new RouteCut(new HighDensityNebula(1), 500) }, new Vaclas(new PhotonicDeflector()), new Message(Message.CrashMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(1), 200), new RouteCut(new Space(4, 2)), new RouteCut(new HighDensityNebula(1), 500) }, new Avgur(new PhotonicDeflector()), new Message(Message.LackRangeMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(1), 200), new RouteCut(new Space(2, 1)) }, new Vaclas(), new Message(Message.CrashMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(1), 200), new RouteCut(new Space(4, 2)), new RouteCut(new Space(3, 0), 200) }, new Stella(), new Message(Message.CrashMessage) };
        yield return new object[] { new Collection<RouteCut> { new RouteCut(new NeutrinoPerticleNebula(1), 200), new RouteCut(new Space(4, 2)), new RouteCut(new Space(3, 0), 200) }, new Avgur(), new Message() };
    }

    // Avgur has small maxRange
    // Pleassure has not JumpEngine
    [Theory]
    [MemberData(nameof(GetDataCase1))]
    private void TheoryLooseTestAvgurPleassureCase1(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }

    // Vaclas without photonic deflector is die
    // Vaclas with photonic deflector is ok
    [Theory]
    [MemberData(nameof(GetDataCase2))]
    private void TheoryTestVaclasFlareCase2(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }

    // Vaclas was crashed because he had been damaging a CosmoWhale
    // Avgur has the strongest deflector who can defend of CosmoWhale
    // Meridian was not crached because he had antimiterFlare
    [Theory]
    [MemberData(nameof(GetDataCase3))]
    private void TheoryTestThreeShipsCase3(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }

    // must be selected Pleassure
    [Fact]
    private void FactTestPleassureAvgurCase4()
    {
        var testShipSelector = new ShipSelector(new Collection<Analyzer> { new Analyzer(new Collection<RouteCut> { new RouteCut(new Space(), 100) }, new Vaclas()), new Analyzer(new Collection<RouteCut> { new RouteCut(new Space(), 100) }, new PleasureShuttle()) });
        Assert.True(testShipSelector.Selector() is PleasureShuttle);
    }

    // must be selected Stella because Avgur cannot cross medium subspace chanel
    [Fact]
    private void FactTestAvgurStellaCase5()
    {
        var testShipSelector = new ShipSelector(new Collection<Analyzer> { new Analyzer(new Collection<RouteCut> { new RouteCut(new HighDensityNebula(), 505) }, new Avgur()), new Analyzer(new Collection<RouteCut> { new RouteCut(new HighDensityNebula(), 505) }, new Stella()) });
        Assert.True(testShipSelector.Selector() is Stella);
    }

    // my cases
    [Theory]
    [MemberData(nameof(GetDataStudentCase))]
    private void TheoryStudentCase(IEnumerable<RouteCut> testCut, IShip testShip, Message waitingAnswer)
    {
        var analyzer = new Analyzer(testCut, testShip);
        Assert.Equal(analyzer.Answer, waitingAnswer);
    }
}
