using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class ModeConnectFlagChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("-m") && context.Command.Contains("connect"))
        {
            FileSystem.ChangeMode(context.Command.ElementAt(3));
        }
        else if (!context.Command.Contains("connect"))
        {
            Next?.Handle(context);
        }
    }
}