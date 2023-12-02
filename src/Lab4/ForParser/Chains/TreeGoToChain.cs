using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class TreeGoToChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("tree") && context.Command.Contains("goto") && context.Command.Count() == 3)
        {
            invoker.SetCommand(new TreeGoToCommand(context));
        }
        else
        {
            Next?.Handle(context, invoker);
        }
    }
}