using Application.Exceptions;
using Models;
using Ports;

namespace Application;

public class AdminLogin : ICommand
{
    private readonly string _username;
    private readonly string _password;
    private readonly IOperationRepository? _operationRepository;
    private readonly IAdminRepository? _adminRepository;

    public AdminLogin(string username, string password, IAdminRepository? adminRepository, IOperationRepository? operationRepository)
    {
        _username = username;
        _password = password;
        _operationRepository = operationRepository;
        _adminRepository = adminRepository;
    }

    public async Task ExecuteAsync()
    {
        // override ==
        if (_adminRepository != null)
        {
            IAdmin result = await _adminRepository.GetByUsernameAsync(_username).ConfigureAwait(false);
            if (result.Password != _password)
            {
                throw new WrongPasswordException();
            }
        }
    }
}