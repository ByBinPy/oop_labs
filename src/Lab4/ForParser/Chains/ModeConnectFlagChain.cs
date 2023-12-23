using System.Linq;
namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class ModeConnectFlagChain : BaseChain
{
    public override void Handle(Context context, IInvoker invoker)
    {
        if (context.Command.Contains("-m") && context.Command.Contains("connect"))
        {
            invoker.SetCommand(new ConnectModeCommand(context));
        }
        else if (!context.Command.Contains("connect"))
        {
            Next?.Handle(context, invoker);
        }
    }

    // edit
}