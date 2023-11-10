using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class GroupDestination : IDestination
{
    private readonly List<IDestination> _destinations;

    public GroupDestination(IEnumerable<IDestination> destinations)
    {
        _destinations = new List<IDestination>(destinations);
    }

    public void SendMessage(IMessage message)
    {
        if (message == null)
            return;
        foreach (IDestination destination in _destinations)
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