using Models;
using Ports;

namespace Infrastructure.Repositories;

public class OperationRepository : IOperationRepository
{
    public async Task GetOperationHistoryByAccountAsync(int numberAccount)
    {
        await Task.Delay(100).ConfigureAwait(false);
    }

    public Task AddAsync(IOperation operation)
    {
        throw new NotImplementedException();
    }
}