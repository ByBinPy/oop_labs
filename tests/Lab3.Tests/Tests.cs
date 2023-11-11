using System.Collections;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessenger;
using Itmo.ObjectOrientedProgramming.Lab3.ForTopic;
using Itmo.ObjectOrientedProgramming.Lab3.ForUser;
using NSubstitute;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;
public static class Tests
{
    [Fact]
    public static void TrySimpleSendMessage()
    {
        var user = new User(1, 10);
        var message = new DefaultMessage("First message", "Bla-Bla-Bla...", 11);
        DefaultTopic topic = DefaultTopic.Builder
            .WithName("simple")
            .WithDestination(new UserDestination(user))
            .WithMessage(message)
            .Build();
        topic.SendMessage();
        Assert.False(user.GetStatusMessage(message.Head));
    }

    [Fact]
    public static void TryChangeStatusNotViewedMessage()
    {
        var user = new User(1, 10);
        var message = new DefaultMessage("First message", "Bla-Bla-Bla...", 11);
        DefaultTopic topic = DefaultTopic.Builder
            .WithName("simple")
            .WithDestination(new UserDestination(user))
            .WithMessage(message)
            .Build();
        topic.SendMessage();
        user.ChangeStatus(message.Head);
        Assert.True(user.GetStatusMessage(message.Head));
    }

    [Fact]
    public static void TryChangeStatusViewedMessage()
    {
        var user = new User(1, 10);
        var message = new DefaultMessage("First message", "Bla-Bla-Bla...", 11);
        DefaultTopic topic = DefaultTopic.Builder
            .WithName("simple")
            .WithDestination(new UserDestination(user))
            .WithMessage(message)
            .Build();
        topic.SendMessage();
        user.ChangeStatus(message.Head);
        Assert.False(user.ChangeStatus(message.Head));
    }

    [Fact]
    public static void TrySendMessageToUserWithInappropriateStatus()
    {
        IMessage defaultMessage = new DefaultMessage("Head", "Bla-Bla-Bla", 10);
        UserDestination? moq = Substitute.For<UserDestination>(new User(1, 9));
        DefaultTopic topic = DefaultTopic.Builder
            .WithName("Name")
            .WithMessage(defaultMessage)
            .WithDestination(new ProxyUserDestination(moq))
            .Build();
        topic.SendMessage();
        Assert.DoesNotContain(moq.ReceivedCalls(), call => call.GetMethodInfo().Name == "SendMessage");
    }

    [Fact]
    public static void TryLoggingWhenMessageWasSendToDestination()
    {
        IMessage defaultMessage = new DefaultMessage("Head", "Bla-Bla-Bla", 11);
        var userDestination = new UserDestination(new User(1, 9));
        ILogger moq = Substitute.For<ILogger>();
        var proxyUserDestination = new ProxyUserDestination(userDestination, moq);
        proxyUserDestination.SendMessage(defaultMessage);
        IEnumerable enumerable = moq.ReceivedCalls();
        Assert.Single(moq.ReceivedCalls().Where(call => call.GetMethodInfo().Name == "Logging"));
    }

    [Fact]
    public static void TrySendMessageToMessenger()
    {
        IMessage defaultMessage = new DefaultMessage("Head", "Bla-Bla-Bla", 11);
        IMessenger moq = Substitute.For<IMessenger>();
        var proxyMessangerDestination = new ProxyMessengerDestination(new MessengerDestination(moq));
        proxyMessangerDestination.SendMessage(defaultMessage);
        IEnumerable enumerable = moq.ReceivedCalls();
        Assert.Single(moq.ReceivedCalls().Where(call => call.GetMethodInfo().Name == "AcceptMessage"));
    }
}