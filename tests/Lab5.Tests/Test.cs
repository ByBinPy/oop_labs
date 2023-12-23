using System.Linq;
using Application;
using Application.Exceptions;
using NSubstitute;
using Port.Ports;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;
public static class Test
{
    [Fact]
    public static void TryRefill()
    {
        IAccountRepository? moq = Substitute.For<IAccountRepository>();
        moq.FindByAccountAsync(100);
        Assert.Equal(1, moq.ReceivedCalls().Count(call => call.GetMethodInfo().Name == "SetCommand"));
    }

    [Fact]
    public static void TryUnknownCommand()
    {
        IParser parser = new Parser();
        try
        {
            parser.ParseAsync(new Context("uullulululu ulululu".Split(" ")));
        }
        catch (InvalidInputException)
        {
            Assert.True(true);
        }

        Assert.True(false);
    }
}