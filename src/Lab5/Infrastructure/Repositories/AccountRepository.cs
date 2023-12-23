using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Models;
using Npgsql;
using Port.Ports;
namespace Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly IPostgresConnectionProvider _postgresConnectionProvider;
    public AccountRepository(IPostgresConnectionProvider postgresConnectionProvider)
    {
        _postgresConnectionProvider = postgresConnectionProvider;
    }

    public async Task<IBankAccount> FindByAccountAsync(int accountNumber)
    {
        const string sql = """
                            select account_id, balance
                            from bank_accounts
                            where account_id = :accountNumber
                            """;
        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command.AddParameter("accountNumber", accountNumber);
        using (NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false))
        {
            if (!await reader.ReadAsync().ConfigureAwait(false)) return new BankAccount(-1, -1, -1);

            return new BankAccount(accountNumber, reader.GetInt32(2), reader.GetInt32(3));
        }
    }

    public async Task AddAsync(IBankAccount bankAccount)
    {
        const string sql = """
                           insert into bank_accounts (bank_account, balance)
                           values (:account, :balance)
                           """;
        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command
            .AddParameter("account", bankAccount.Account)
            .AddParameter("balance", bankAccount.Balance);
        await command.ExecuteNonQueryAsync()
            .ConfigureAwait(false);
    }

    public async Task UpdateAsync(int account, int diffBalance)
    {
        const string sql = """
                           update bank_accounts
                           set balance = balance + :diffBalance
                           where bank_account = :account
                           """;

        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command
            .AddParameter("account", account)
            .AddParameter("diffBalance", diffBalance);
        await command.ExecuteNonQueryAsync()
            .ConfigureAwait(false);
    }

    public async Task DeleteAsync(int account)
    {
        const string sql = """
                           delete from  bank_accounts
                           where bank_account = :account
                           """;

        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command
            .AddParameter("account", account);
        await command.ExecuteNonQueryAsync()
            .ConfigureAwait(false);
    }
}