using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
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

    public async Task AddAsync(IAdmin admin)
    {
        const string sql = """
                           insert into bank_accounts (username, password)
                           values (:name, :pasw)
                           """;
        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command
            .AddParameter("name", admin.UserName)
            .AddParameter("pasw", admin.Password);
        await command.ExecuteNonQueryAsync()
            .ConfigureAwait(false);
    }

    public async Task DeleteAsync(IAdmin admin)
    {
        const string sql = """
                           delete from bank_accounts
                           where username = :name
                           """;
        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command
            .AddParameter("name", admin.UserName);
        await command.ExecuteNonQueryAsync()
            .ConfigureAwait(false);
    }

    public async Task<IAdmin> GetByUsernameAsync(string username)
    {
        const string sql = """
                           select username, password
                           from admins
                           where username = :user
                           """;
        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command.AddParameter("user", username);
        using (NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false))
        {
            if (!await reader.ReadAsync().ConfigureAwait(false)) return new Admin(string.Empty, string.Empty);

            return new Admin(username, reader.GetString(1));
        }
    }
}