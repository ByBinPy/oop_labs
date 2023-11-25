using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class TreeListChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("tree") && context.Command.Contains("list"))
        {
            PullFiles.ShowEntries(FileSystem.Path + (NavigationStackTree.TopDirectory()?.Path ?? string.Empty));
        }

        Next?.Handle(context);
    }
}