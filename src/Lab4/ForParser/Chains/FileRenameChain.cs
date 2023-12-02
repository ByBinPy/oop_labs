using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileRenameChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (FileSystem.Path.Length == 0)
            throw new ConnectException(nameof(DepthFlagChain));

        if (context.Command.Contains("file") && context.Command.Contains("rename") && context.Command.Count() == 4)
        {
            invoker.SetCommand(new FileRenameCommand(context));
        }

        Next?.Handle(context, invoker);
    }
}