namespace Models;

public class BankAccount : IBankAccount
{
    public BankAccount(int balance, int account)
    {
        Balance = balance;
        Account = account;
    }

    public int Account { get; }
    public int Balance { get; }
}