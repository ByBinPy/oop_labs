using Models;
using Ports;

namespace Application;

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
        }
        else
        {
            throw new NotImplementedException();
        }

        if (_operationRepository != null)
        {
            await _operationRepository.AddAsync(new Operation(_account, DateTime.Now, TypeOperation.Find)).ConfigureAwait(false);
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}