using Application.Exceptions;
using Models;
using Port.Ports;

namespace Application.Chains.Commands;

public class AdminShow : ICommand
{
    private readonly int _account;
    private readonly IAccountRepository? _accountRepository;
    private readonly IOperationRepository? _operationRepository;

    public AdminShow(int account, IAccountRepository? accountRepository, IOperationRepository? operationRepository)
    {
        _account = account;
        _accountRepository = accountRepository;
        _operationRepository = operationRepository;
    }

    public async Task ExecuteAsync()
    {
        if (_accountRepository != null)
        {
            IBankAccount account = await _accountRepository.FindByAccountAsync(_account).ConfigureAwait(false);
            Console.WriteLine($"balance :={account.Balance}");
        }
        else
        {
            throw new NullRepoException();
        }

        if (_operationRepository != null)
        {
            await _operationRepository.AddAsync(new Operation(_account, TypeOperation.Find)).ConfigureAwait(false);
        }
        else
        {
            throw new NullRepoException();
        }
    }
}