namespace Models;

public class Operation : IOperation
{
    public Operation(int bankAccount, DateTime timeOperation, TypeOperation typeOperation)
    {
        BankAccount = bankAccount;
        TimeOperation = timeOperation;
        TypeOperation = typeOperation;
    }

    public DateTime TimeOperation { get; }
    public int BankAccount { get; }
    public TypeOperation TypeOperation { get; }
}