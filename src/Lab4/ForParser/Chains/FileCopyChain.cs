using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileCopyChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("file") && context.Command.Contains("copy") && context.Command.Count() == 4)
        {
            invoker.SetCommand(new FileCopyCommand(context));
        }

        Next?.Handle(context, invoker);
    }
}