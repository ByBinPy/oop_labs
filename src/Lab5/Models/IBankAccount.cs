namespace Models;

public interface IBankAccount
{
    int Account { get; }
    int Balance { get; }
    int Pin { get; }
}