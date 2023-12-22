using Models;

namespace Ports;

public interface IOperationRepository
{
    Task GetOperationHistoryByAccountAsync(int numberAccount);
    Task AddAsync(IOperation operation);
}