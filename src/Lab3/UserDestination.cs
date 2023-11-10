namespace Itmo.ObjectOrientedProgramming.Lab3;

public class UserDestination : IDestination
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