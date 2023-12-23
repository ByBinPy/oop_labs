using Application.Exceptions;
using Models;
using Port.Ports;

namespace Application.Chains.Commands;

public class UserShow : ICommand
{
    private readonly int _account;
    private readonly int _pin;
    private readonly IAccountRepository? _accountRepository;
    private readonly IOperationRepository? _operationRepository;

    public UserShow(int account, int pin, IAccountRepository? accountRepository, IOperationRepository? operationRepository)
    {
        _account = account;
        _pin = pin;
        _accountRepository = accountRepository;
        _operationRepository = operationRepository;
    }

    public async Task ExecuteAsync()
    {
        if (_accountRepository != null)
        {
            IBankAccount result = await _accountRepository.FindByAccountAsync(_account).ConfigureAwait(false);
            if (result.Pin == _pin)
            {
                Console.WriteLine($"balance :={result.Balance}");
            }
            else
            {
                throw new WrongPasswordException();
            }
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