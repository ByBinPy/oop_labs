using Models;

namespace Ports;

public interface IOperationRepository
{
    IAsyncEnumerable<string> GetOperationHistoryByAccountAsync(int numberAccount);
    Task AddAsync(IOperation operation);
}