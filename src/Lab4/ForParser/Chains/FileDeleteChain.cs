using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileDeleteChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("file") && context.Command.Contains("delete") && context.Command.Count() == 3)
        {
            invoker.SetCommand(new FileDeleteCommand(context));
        }

        Next?.Handle(context, invoker);
    }
}