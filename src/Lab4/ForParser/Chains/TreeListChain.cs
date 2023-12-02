using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class TreeListChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("tree") && context.Command.Contains("list"))
        {
            invoker.SetCommand(new TreeListCommand());
        }

        Next?.Handle(context, invoker);
    }
}