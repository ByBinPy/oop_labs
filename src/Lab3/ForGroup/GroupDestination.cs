using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForGroup;

public class GroupDestination : IDestination
{
    private readonly IList<IDestination> _destinations;
    public GroupDestination(IEnumerable<IDestination> destinations)
    {
        _destinations = new List<IDestination>(destinations);
    }

    public void AddDestination(IDestination destination)
    {
        _destinations.Add(destination);
    }

    public void RemoveDestination(IDestination destination)
    {
        _destinations.Remove(destination);
    }

    public void SendMessage(IMessage message)
    {
        foreach (IDestination destination in _destinations)
        {
            destination.SendMessage(message);
        }
    }
}