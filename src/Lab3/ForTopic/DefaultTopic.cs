using System;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForTopic;

public class DefaultTopic : ITopic
{
    private DefaultTopic(string name, ISender destination, IMessage message)
    {
        Name = name;
        Destination = destination;
        Message = message ?? throw new ArgumentNullException(nameof(message));
    }

    public string Name { get; }

    public ISender Destination { get; private set; }

    public IMessage Message { get; private set; }

    public void SendMessage(IMessage message)
    {
        Destination.SendMessage(message);
    }

    public class DefaultTopicBuilder
    {
        private string? _name;
        private ISender? _destination;
        private IMessage? _message;
        public DefaultTopicBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public DefaultTopicBuilder WithDestination(ISender destination)
        {
            _destination = destination;
            return this;
        }

        public DefaultTopicBuilder WithMessage(IMessage message)
        {
            _message = message;
            return this;
        }
    }
}