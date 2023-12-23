using CLI;
using Infrastructure.Extensions;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Ports;

namespace Application.Chains;

public class ChangeStateChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        IServiceCollection serviceCollectionExtensions = new ServiceCollection().AddExtensions();
        ServiceProvider provider = serviceCollectionExtensions.BuildServiceProvider();

        if (context.Input.ElementAt(0) == "change")
        {
            if (Parser.State is UserParser)
            {
                invoker.SetCommand(new AdminLogin(
                    context.Input.ElementAt(1),
                    context.Input.ElementAt(1),
                    provider.GetService<IAdminRepository>(),
                    provider.GetService<OperationRepository>()));
                Parser.ChangeState();
            }

            if (Parser.State is AdminParser)
            {
                Parser.ChangeState();
            }

            return;
        }

        Next?.Handle(context, invoker);
    }
}