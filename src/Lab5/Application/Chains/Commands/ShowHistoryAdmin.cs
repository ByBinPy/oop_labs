using Application.Exceptions;
using Models;
using Port.Ports;

namespace Application.Chains.Commands;

public class ShowHistoryAdmin : ICommand
{
    private readonly int _account;
    private readonly IOperationRepository? _operationRepository;

    public ShowHistoryAdmin(int account, IOperationRepository? operationRepository)
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