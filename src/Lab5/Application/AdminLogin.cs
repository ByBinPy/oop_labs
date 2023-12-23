using CLI;
using Ports;

namespace Application;

public class AdminLogin : ICommand
{
    private readonly string _username;
    private readonly string _password;
    private readonly IOperationRepository _operationRepository;
    private readonly IAccountRepository _accountRepository;

    public AdminLogin(string username, string password, IOperationRepository operationRepository, IAccountRepository accountRepository)
    {
        _username = username;
        _password = password;
        _operationRepository = operationRepository;
        _accountRepository = accountRepository;
    }

    public async Task ExecuteAsync()
    {
        _
    }
}