using Application.Exceptions;
using Models;
using Port.Ports;
using Ports;

namespace Application;

public class UserRefill : ICommand
{
    private readonly int _account;
    private readonly int _pin;
    private readonly int _diffBalance;
    private IAccountRepository? _accountRepository;
    private IOperationRepository? _operationRepository;
    public UserRefill(int account, int pin, int diffBalance, IAccountRepository? accountRepository, IOperationRepository? operationRepository)
    {
        _account = account;
        _pin = pin;
        _diffBalance = diffBalance;
        _accountRepository = accountRepository;
        _operationRepository = operationRepository;
    }

    public async Task ExecuteAsync()
    {
        if (_accountRepository != null)
        {
            IBankAccount bankAccount = await _accountRepository.FindByAccountAsync(_account).ConfigureAwait(false);
            if (bankAccount.Pin != _pin)
            {
                throw new WrongPasswordException();
            }

            if (bankAccount.Balance + _diffBalance < 0)
            {
                throw new IncorrectAmount();
            }

            await _accountRepository.UpdateAsync(_account, _diffBalance).ConfigureAwait(false);
        }
        else
        {
            throw new NullRepoException();
        }

        if (_operationRepository != null)
        {
            await _operationRepository.AddAsync(new Operation(_account, TypeOperation.UpdateBalance))
                .ConfigureAwait(false);
        }
        else
        {
            throw new NullRepoException();
        }
    }
}