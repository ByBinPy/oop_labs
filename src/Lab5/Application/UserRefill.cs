using Models;
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
                throw new NotImplementedException();
            }
        }

        if (_accountRepository != null)
        {
            await _accountRepository.UpdateAsync(_account, _diffBalance).ConfigureAwait(false);
        }
        else
        {
            throw new NotImplementedException();
        }

        if (_operationRepository != null)
        {
            await _operationRepository.AddAsync(new Operation(_account, DateTime.Now, TypeOperation.Refill))
                .ConfigureAwait(false);
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}