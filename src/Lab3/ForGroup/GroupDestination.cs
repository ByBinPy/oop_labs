using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForGroup;

public class GroupDestination : ISender
{
    private readonly List<ISender> _destinations;

    public GroupDestination()
    {
        _destinations = new List<ISender>();
    }

    public GroupDestination(IEnumerable<ISender> destinations)
    {
        _destinations = new List<ISender>(destinations);
    }

    public void AddDestination(ISender destination)
    {
        _destinations.Add(destination);
    }

    public void RemoveDestination(ISender destination)
    {
        _destinations.Remove(destination);
    }

    public void SendMessage(IMessage message)
    {
        if (message == null)
            return;
        foreach (ISender destination in _destinations)
        {
            if (destination is UserDestination)
            {
                var userDestination = (UserDestination)destination;
                if (userDestination.User.Priority < message.Priority)
                    userDestination.SendMessage(message);
            }

            destination.SendMessage(message);
        }
    }
}