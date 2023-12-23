using CLI;
using Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Port.Ports;

namespace Application.Chains;

public class AdminAuthChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (context.Input.ElementAt(0) == "admin")
        {
            IServiceCollection serviceCollectionExtensions = new ServiceCollection().AddExtensions();
            ServiceProvider provider = serviceCollectionExtensions.BuildServiceProvider();
            invoker.SetCommand(
                new AdminLogin(
                    context.Input.ElementAt(1),
                    context.Input.ElementAt(2),
                    provider.GetService<IAdminRepository>(),
                    provider.GetService<IOperationRepository>()));

            return;
        }

        Next?.Handle(context, invoker);
    }
}