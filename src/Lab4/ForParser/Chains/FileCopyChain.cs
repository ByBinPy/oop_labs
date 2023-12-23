using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileCopyChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (FileSystem.Path.Length == 0)
            throw new ConnectException(nameof(DepthFlagChain));

        if (context.Command.Contains("file") && context.Command.Contains("copy") && context.Command.Count() == 4)
        {
            invoker.SetCommand(new FileCopyCommand(context));
        }

        Next?.Handle(context, invoker);
    }
}