using Application;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Port.Ports;

namespace Ports.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IBankAccount, BankAccount>();
        collection.AddScoped<IOperation, Operation>();
        collection.AddScoped<IAdmin, Admin>();
        collection.AddScoped<IParser, Parser>();
        return collection;
    }
}
