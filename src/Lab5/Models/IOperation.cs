namespace Models;

public interface IOperation
{
     DateTime TimeOperation { get; }
     IBankAccount BankAccount { get; }
     TypeOperation TypeOperation { get; }
}