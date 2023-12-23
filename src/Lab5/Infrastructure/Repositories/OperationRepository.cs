using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Models;
using Npgsql;
using Port.Ports;

namespace Infrastructure.Repositories;

public class OperationRepository : IOperationRepository
{
    private IPostgresConnectionProvider _postgresConnectionProvider;

    public OperationRepository(IPostgresConnectionProvider postgresConnectionProvider)
    {
        _postgresConnectionProvider = postgresConnectionProvider;
    }

    public async IAsyncEnumerable<string> GetOperationHistoryByAccountAsync(int numberAccount)
    {
        const string sql = """
                           select operation_id, account_id, type_operation
                           from bank_accounts,
                           where account_id = :accountNumber,
                           """;
        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, npgsqlConnection);
        command.AddParameter("accountNumber", numberAccount);
        using (NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false))
        {
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                yield return
                    $"operation_id:{reader.GetString(0)}, account:{reader.GetString(1)} type_operation:{reader}";
            }
        }
    }

    public Task AddAsync(IOperation operation)
    {
        throw new NotImplementedException();
    }

    async Task IOperationRepository.AddAsync(IOperation operation)
    {
        const string sqlLogging = """
                                     insert into operations (account_id,type_operation)
                                     values (:account, :type)
                                  """;
        NpgsqlConnection npgsqlConnection =
            await _postgresConnectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sqlLogging, npgsqlConnection);
        await command
            .AddParameter("account", operation.BankAccount)
            .AddParameter("type", TypeOperation.Find)
            .ExecuteNonQueryAsync()
            .ConfigureAwait(false);
    }
}