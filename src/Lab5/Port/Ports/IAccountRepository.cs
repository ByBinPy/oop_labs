using Models;

namespace Port.Ports;

public interface IAccountRepository
{
    Task<IBankAccount> FindByAccountAsync(int accountNumber);
    Task AddAsync(IBankAccount bankAccount);
    Task UpdateAsync(int account, int diffBalance);
    Task DeleteAsync(int account);
}