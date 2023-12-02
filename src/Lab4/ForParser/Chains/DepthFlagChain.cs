using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class DepthFlagChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (FileSystem.Path.Length == 0)
            throw new ConnectException(nameof(DepthFlagChain));

        if (context.Command.Contains("tree") && context.Command.Contains("list"))
        {
            if (context.Command.Contains("-d"))
            {
                invoker.SetCommand(new DepthFlagCommand(context));
            }
        }
        else
        {
            Next?.Handle(context, invoker);
        }
    }
}