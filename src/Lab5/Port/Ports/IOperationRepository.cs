using Models;

namespace Port.Ports;

public interface IOperationRepository
{
    IAsyncEnumerable<string> GetOperationHistoryByAccountAsync(int numberAccount);
    Task AddAsync(IOperation operation);
}