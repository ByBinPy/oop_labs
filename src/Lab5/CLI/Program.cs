// See https://aka.ms/new-console-template for more information

#pragma warning disable IDE0005
using Infrastructure.Extensions;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Models.Extensions;
using Npgsql;
using Ports;
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
IAccountRepository? accountRepository = provider.GetService<IAccountRepository>();
await accountRepository.AddAsync(new BankAccount(100, 200, 123)).ConfigureAwait(false);
await accountRepository.AddAsync(new BankAccount(100, 201, 122)).ConfigureAwait(false);
await accountRepository.AddAsync(new BankAccount(100, 202, 123)).ConfigureAwait(false);
await accountRepository.AddAsync(new BankAccount(100, 203, 123)).ConfigureAwait(false);
Console.WriteLine((await accountRepository.FindByAccountAsync(201).ConfigureAwait(false)).Account);
