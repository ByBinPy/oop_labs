using Itmo.Dev.Platform.Postgres.Connection;
using Models;
using Npgsql;
using Ports;

namespace Infrastructure.Repositories;

public class AdminRepository : IAdminRepository
{
    private readonly IPostgresConnectionProvider _postgresConnectionProvider;
    private NpgsqlConnection _npgsqlConnection;

    public AdminRepository(IPostgresConnectionProvider postgresConnectionProvider, NpgsqlConnection npgsqlCommand)
    {
        _postgresConnectionProvider = postgresConnectionProvider;
        _npgsqlConnection = npgsqlCommand;
    }

    public Task AddAsync(IAdmin admin)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(IAdmin admin)
    {
        throw new NotImplementedException();
    }

    public Task<IAdmin> GetByUsernameAsync(string username)
    {
        throw new NotImplementedException();
    }
}