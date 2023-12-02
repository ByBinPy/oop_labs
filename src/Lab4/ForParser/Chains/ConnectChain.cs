using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class ConnectChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        if (context.Command.Contains("connect"))
            invoker.SetCommand(new ConnectFileSystemCommand(context));

        if (FileSystem.Path.Length > 0)
        {
            Next?.Handle(context, invoker);
        }
        else
        {
            throw new ConnectException(nameof(ConnectChain) + FileSystem.Path);
        }
    }

    // edit
}