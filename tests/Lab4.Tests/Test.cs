using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;
using Itmo.ObjectOrientedProgramming.Lab4.ForParser;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;
public static class Test
{
    [Fact]
    public static void TryConnectToSrc()
    {
        string? testPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory())?.Parent?.FullName ?? string.Empty)?.FullName ?? string.Empty)?.FullName ?? string.Empty)?.FullName;

        // Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string request = $"connect {testPath} -m local";
        var parser = new Parser(new Invoker());
        parser.Parse(new Context(request.Split(" ")));
        parser.Invoker.Execute();
        Assert.Equal(testPath, FileSystem.Path);
    }

    [Fact]
    public static void TryGoToObj()
    {
        string? testPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory())?.Parent?.FullName ?? string.Empty)?.FullName ?? string.Empty)?.FullName ?? string.Empty)?.FullName;
        string request1 = $"connect {testPath} -m local";
        string request2 = @"tree goto \src";
        var parser = new Parser(new Invoker());
        parser.Parse(new Context(request1.Split(" ")));
        parser.Parse(new Context(request2.Split(" ")));
        parser.Invoker.Execute();
        Assert.Equal(@"\src", NavigationStackTree.TopDirectory()?.Path);
    }

    [Fact]
    public static void TryShowTreeList()
    {
        while (NavigationStackTree.TopDirectory() != null)
        {
            NavigationStackTree.PopDirectory();
        }

        string? testPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory())?.Parent?.FullName ?? string.Empty)?.FullName ?? string.Empty)?.FullName ?? string.Empty)?.FullName;
        string request1 = $@"connect {testPath} -m local";
        string request2 = "tree list";
        IDataShow mok = Substitute.For<IDataShow>();
        var parser = new Parser(new Invoker());
        PullFiles.SetDataShow(mok);
        parser.Parse(new Context(request1.Split(" ")));
        parser.Parse(new Context(request2.Split(" ")));
        parser.Invoker.Execute();
        Assert.Equal(14, mok.ReceivedCalls().Count(call => call.GetMethodInfo().Name == "Show"));
    }
}