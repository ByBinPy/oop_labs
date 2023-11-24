using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class DisconnectChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("disconnect"))
        {
            FileSystemPath.ChangeSystemPath(context.Command.ElementAt(0));
        }
    }
}