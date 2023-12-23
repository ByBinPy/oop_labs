namespace Models;

public class Operation : IOperation
{
    public Operation(int bankAccount, TypeOperation typeOperation)
    {
        BankAccount = bankAccount;
        TypeOperation = typeOperation;
    }

    public int BankAccount { get; }
    public TypeOperation TypeOperation { get; }
}