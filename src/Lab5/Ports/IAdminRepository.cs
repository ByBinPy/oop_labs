using Models;

namespace Ports;

public interface IAdminRepository
{
    Task AddAsync(IAdmin admin);
    Task DeleteAsync(IAdmin admin);
    Task<IAdmin> GetByUsernameAsync(string username);
}