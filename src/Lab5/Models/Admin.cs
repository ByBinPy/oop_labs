namespace Models;

public class Admin : IAdmin
{
    public Admin(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public string UserName { get; }
    public string Password { get; }
}