using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class ModeConnectFlagChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("-m") && context.Command.Contains("connect"))
        {
            invoker.SetCommand(new ConnectModeCommand(context));
        }
        else if (!context.Command.Contains("connect"))
        {
            Next?.Handle(context, invoker);
        }

        if (FileSystem.Path.Length == 0)
            throw new ConnectException(nameof(DepthFlagChain));
    }

    // edit
}