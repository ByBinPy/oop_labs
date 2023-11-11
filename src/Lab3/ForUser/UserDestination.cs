using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;
using Itmo.ObjectOrientedProgramming.Lab3.ForUser;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class UserDestination : IDestination
{
    private readonly User _user;
    public UserDestination(User user)
    {
        _user = user;
    }

    public void SendMessage(IMessage message)
    {
        _user.AcceptMessage(message);
    }
}