using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class GroupDestination : ISender
{
    private readonly List<ISender> _destinations;

    public GroupDestination(IEnumerable<ISender> destinations)
    {
        _destinations = new List<ISender>(destinations);
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