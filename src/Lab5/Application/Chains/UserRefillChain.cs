using System.Globalization;
using Application.Chains.Commands;
using CLI;
using Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Port.Ports;

namespace Application.Chains;
/*
 form - Refill Account Pin DiffBalance
 */
public class UserRefillChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (context.Input.ElementAt(0) == "refill")
        {
            IServiceCollection serviceCollectionExtensions = new ServiceCollection().AddExtensions();
            ServiceProvider provider = serviceCollectionExtensions.BuildServiceProvider();
            invoker.SetCommand(
                new UserRefill(
                    Convert.ToInt32(context.Input.ElementAt(1), CultureInfo.CurrentCulture),
                    Convert.ToInt32(context.Input.ElementAt(2), CultureInfo.CurrentCulture),
                    Convert.ToInt32(context.Input.ElementAt(3), CultureInfo.CurrentCulture),
                    provider.GetService<IAccountRepository>(),
                    provider.GetService<IOperationRepository>()));

            return;
        }

        Next?.Handle(context, invoker);
    }
}