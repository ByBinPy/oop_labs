using Models;
using Ports;

namespace Application;

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