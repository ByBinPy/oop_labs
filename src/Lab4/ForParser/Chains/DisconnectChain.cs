using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class DisconnectChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (FileSystem.Path.Length == 0)
            throw new ConnectException(nameof(DepthFlagChain));

        if (context.Command.Contains("disconnect"))
        {
            invoker.SetCommand(new DisconnectCommand());
        }
        else
        {
            Next?.Handle(context, invoker);
        }
    }
}