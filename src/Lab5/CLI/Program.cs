// See https://aka.ms/new-console-template for more information

#pragma warning disable IDE0005
using Application;
using CLI;
using Infrastructure.Extensions;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Npgsql;
using Port.Ports;
using Ports;
using Ports.Extensions;

#pragma warning restore IDE0005
#pragma warning disable CS8602 // Dereference of a possibly null reference.
var collection = new ServiceCollection();

collection
    .AddInfrastructureDataAccess(configuration =>
    {
        configuration.Host = "localhost";
        configuration.Port = 6432;
        configuration.Username = "postgres";
        configuration.Password = "postgres";
        configuration.Database = "postgres";
        configuration.SslMode = "Prefer";
    })
    .AddApplication();

ServiceProvider provider = collection.BuildServiceProvider();
using IServiceScope scope = provider.CreateScope();
scope.UseInfrastructureDataAccess();
Console.WriteLine($"if user:\nrefill [account] [pin] [diffAmount]\nshow [account] [account], [pin]\nhistory [account]\nchange [username] [password]");
Console.WriteLine($"admin [username] [password]\nIf admin: \nshow [account]\nchange\nhistory [account]");
while (true)
{
    IParser? parser = provider.GetService<IParser>();
    var context = new Context(Console.ReadLine().Split(" "));
    await parser.ParseAsync(context).ConfigureAwait(false);
}
