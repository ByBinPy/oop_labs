namespace Models;

public class BankAccount : IBankAccount
{
    public BankAccount(int balance, int account, int pin)
    {
        Balance = balance;
        Account = account;
        Pin = pin;
    }

    public int Account { get; }
    public int Balance { get; }
    public int Pin { get; }
}