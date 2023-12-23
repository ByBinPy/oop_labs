using System.Globalization;
using CLI;
using Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Ports;

namespace Application.Chains;

public class AdminShowChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        IServiceCollection serviceCollectionExtensions = new ServiceCollection().AddExtensions();
        ServiceProvider provider = serviceCollectionExtensions.BuildServiceProvider();

        if (context.Input.ElementAt(0) == "show")
        {
            invoker.SetCommand(new AdminShow(
                Convert.ToInt32(context.Input.ElementAt(1), CultureInfo.CurrentCulture),
                provider.GetService<IAccountRepository>(),
                provider.GetService<IOperationRepository>()));
            return;
        }

        Next?.Handle(context, invoker);
    }
}