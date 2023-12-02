using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;
using Itmo.ObjectOrientedProgramming.Lab4.ForParser;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;
public static class Test
{
    [Fact]
    public static void Test1()
    {
        string request = "connect C:\\ -m local";
        var parser = new Parser(new Invoker());
        parser.Parse(new Context(request.Split(" ")));
        Assert.Equal("C:\\", FileSystem.Path);
    }

    [Fact]
    public static void Test2()
    {
        string request1 = @"connect C:\Users\User\RiderProjects\ByBinPy -m local";
        string request2 = @"tree goto \testfilesystem";
        var parser = new Parser(new Invoker());
        parser.Parse(new Context(request1.Split(" ")));
        parser.Parse(new Context(request2.Split(" ")));
        Assert.Equal(@"\testfilesystem", NavigationStackTree.TopDirectory()?.Path);
    }

    [Fact]
    public static void Test3()
    {
        while (NavigationStackTree.TopDirectory() != null)
        {
            NavigationStackTree.PopDirectory();
        }

        string request1 = @"connect C:\Users\User\RiderProjects\ByBinPy\testfilesystem -m local";
        string request2 = @"tree list";
        IDataShow mok = Substitute.For<IDataShow>();
        var parser = new Parser(new Invoker());
        PullFiles.SetDataShow(mok);
        parser.Parse(new Context(request1.Split(" ")));
        parser.Parse(new Context(request2.Split(" ")));
        Assert.Equal(3, mok.ReceivedCalls().Count(call => call.GetMethodInfo().Name == "Show"));
    }
}