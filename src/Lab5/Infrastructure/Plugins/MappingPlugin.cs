using Itmo.Dev.Platform.Postgres.Plugins;
using Models;
using Npgsql;

namespace Infrastructure.Plugins;

public class MappingPlugin : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder)
    {
        builder.MapEnum<TypeOperation>();
    }
}