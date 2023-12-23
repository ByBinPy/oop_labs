namespace Models;

public interface IOperation
{
     DateTime TimeOperation { get; }
     int BankAccount { get; }
     TypeOperation TypeOperation { get; }
}