using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class DepthFlagChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
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