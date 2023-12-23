using Microsoft.Extensions.DependencyInjection;

namespace Models.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IBankAccount, BankAccount>();
        collection.AddScoped<IOperation, Operation>();
        collection.AddScoped(IAdmin, Admin);
        return collection;
    }
}
