using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class ConnectChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (context.Command.Contains("connect"))
            invoker.SetCommand(new ConnectFileSystemCommand(context));

        Next?.Handle(context, invoker);
    }

    // edit
}