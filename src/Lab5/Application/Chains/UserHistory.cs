using Application.Exceptions;
using Models;
using Port.Ports;

namespace Application.Chains;

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
            await _operationRepository.AddAsync(new Operation(_account, TypeOperation.History)).ConfigureAwait(false);
        }
        else
        {
            throw new NullRepoException();
        }
    }
}