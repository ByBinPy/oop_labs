using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class DisconnectChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("disconnect"))
        {
            FileSystem.ChangePath(context.Command.ElementAt(0));
        }
        else
        {
            Next?.Handle(context);
        }
    }
}