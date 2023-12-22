namespace Models;

public class Operation : IOperation
{
    public Operation(IBankAccount bankAccount, DateTime timeOperation, TypeOperation typeOperation)
    {
        BankAccount = bankAccount;
        TimeOperation = timeOperation;
        TypeOperation = typeOperation;
    }

    public DateTime TimeOperation { get; }
    public IBankAccount BankAccount { get; }
    public TypeOperation TypeOperation { get; }
}