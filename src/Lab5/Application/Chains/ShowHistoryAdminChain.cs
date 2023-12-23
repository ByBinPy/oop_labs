using System.Globalization;
using CLI;
using Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Ports;

namespace Application.Chains;

public class ShowHistoryAdminChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (context.Input.ElementAt(0) == "history")
        {
            IServiceCollection serviceCollectionExtensions = new ServiceCollection().AddExtensions();
            ServiceProvider provider = serviceCollectionExtensions.BuildServiceProvider();
            invoker.SetCommand(new ShowHistoryAdmin(
                Convert.ToInt32(context.Input.ElementAt(1), CultureInfo.CurrentCulture),
                provider.GetService<IOperationRepository>()));
            return;
        }

        Next?.Handle(context, invoker);
    }
}