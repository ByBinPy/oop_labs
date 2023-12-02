using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class DisconnectChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
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