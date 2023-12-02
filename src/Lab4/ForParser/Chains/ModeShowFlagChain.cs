using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class ModeShowFlagChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("file") && context.Command.Contains("show"))
        {
            if (context.Command.Count() == 4)
            {
                invoker.SetCommand(new FileShowCommand(context));
            }
        }
        else
        {
            Next?.Handle(context, invoker);
        }
    }
}