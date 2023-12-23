using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileDeleteChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (FileSystem.Path.Length == 0)
            throw new ConnectException(nameof(DepthFlagChain));

        if (context.Command.Contains("file") && context.Command.Contains("delete") && context.Command.Count() == 3)
        {
            invoker.SetCommand(new FileDeleteCommand(context));
        }

        Next?.Handle(context, invoker);
    }
}