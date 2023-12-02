using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileMoveChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("file") && context.Command.Contains("move") && context.Command.Count() == 4)
        {
            invoker.SetCommand(new FileMoveCommand(context));
        }

        Next?.Handle(context, invoker);
    }
}