using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileRenameChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("file") && context.Command.Contains("rename") && context.Command.Count() == 4)
        {
            invoker.SetCommand(new FileRenameCommand(context));
        }

        Next?.Handle(context, invoker);
    }
}