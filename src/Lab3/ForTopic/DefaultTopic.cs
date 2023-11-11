using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForTopic;

public class DefaultTopic
{
    private DefaultTopic(string name, IDestination destination, IMessage message)
    {
        Name = name;
        Destination = destination;
        Message = message ?? throw new ArgumentNullException(nameof(message));
    }

    public static DefaultTopicBuilder Builder => new DefaultTopicBuilder();
    public string Name { get; }
    public IDestination Destination { get; private set; }
    public IMessage Message { get; private set; }

    public void SendMessage()
    {
        Destination.SendMessage(Message);
    }

    public class DefaultTopicBuilder
    {
        private string? _name;
        private IDestination? _destination;
        private IMessage? _message;
        public DefaultTopicBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public DefaultTopicBuilder WithDestination(IDestination destination)
        {
            _destination = destination;
            return this;
        }

        public DefaultTopicBuilder WithMessage(IMessage message)
        {
            _message = message;
            return this;
        }

        public DefaultTopic Build()
        {
            return new DefaultTopic(
                _name ?? throw new ArgumentNullException(nameof(_name)),
                _destination ?? throw new ArgumentNullException(nameof(_destination)),
                _message ?? throw new ArgumentNullException(nameof(_message)));
        }
    }
}