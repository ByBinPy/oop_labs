using Itmo.ObjectOrientedProgramming.Lab3.ForMessage;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class UserDestination : ISender
{
    public UserDestination(User user)
    {
        User = user;
    }

    public User User { get; }

    public void SendMessage(IMessage message)
    {
        User.AcceptMessage(message);
    }
}