using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Models;
using Npgsql;
using Ports;

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
                            from bank_account
                            where account_id = :accountNumber
                            """;

        const string sqlLogging = """
                                     insert into operations (operation_time,account_id,type_operation)
                                     values (:time, :account, :type)
                                  """;

        NpgsqlConnection connection = await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountNumber", accountNumber);
        using (NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false))
        {
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                using var commandLog = new NpgsqlCommand(sqlLogging, connection);
                await commandLog
                    .AddParameter("time", DateTime.Now)
                    .AddParameter("account", accountNumber)
                    .AddParameter("type", TypeOperation.Find)
                    .ExecuteNonQueryAsync()
                    .ConfigureAwait(false);
                return new BankAccount(accountNumber, reader.GetInt32(2));
            }
        }

        return new BankAccount(-1, -1);
    }

    public async Task AddAsync(IBankAccount bankAccount)
    {
        const string sql = """
                           insert into bank_account (bank_account, balance)
                           values (:account, :balance)
                           """;
        using NpgsqlConnection connection = await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, connection);
        command
            .AddParameter("account", bankAccount.Account)
            .AddParameter("balance", bankAccount.Balance);
        await command.ExecuteNonQueryAsync()
            .ConfigureAwait(false);
    }

    public async Task UpdateAsync(int account, int diffBalance)
    {
        const string sql = """
                           insert into bank_account (bank_account, balance)
                           values (:account, :balance)
                           """;

        using NpgsqlConnection connection = await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, connection);
    }

    public async Task DeleteAsync(int account)
    {
        await Task.Delay(100).ConfigureAwait(false);
    }
}