using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3.ForGroup;

public class GroupDestination : IDestination
{
    private readonly IList<DestinationFilter> _destinations;
    public GroupDestination(IEnumerable<DestinationFilter> destinations)
    {
        _destinations = new List<DestinationFilter>(destinations);
    }

    public void AddDestination(DestinationFilter destination)
    {
        _destinations.Add(destination);
    }

    public void RemoveDestination(DestinationFilter destination)
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