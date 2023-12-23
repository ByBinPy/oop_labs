using Models;
using Ports;

namespace Application;

public class UserHistory : ICommand
{
    private readonly int _account;
    private readonly IOperationRepository? _operationRepository;

    public UserHistory(int account, IOperationRepository? operationRepository)
    {
        _account = account;
        _operationRepository = operationRepository;
    }

    public async Task ExecuteAsync()
    {
        if (_operationRepository != null)
        {
            await _operationRepository.GetOperationHistoryByAccountAsync(_account).ConfigureAwait(false);
            await _operationRepository.AddAsync(new Operation(_account, DateTime.Now, TypeOperation.History)).ConfigureAwait(false);
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}