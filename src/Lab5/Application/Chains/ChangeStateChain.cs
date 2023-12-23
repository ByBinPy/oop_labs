using Application.Chains.Commands;
using CLI;
using Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Port.Ports;

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
                    context.Input.ElementAt(2),
                    provider.GetService<IAdminRepository>(),
                    provider.GetService<IOperationRepository>()));
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