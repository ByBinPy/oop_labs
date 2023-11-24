using System;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class TreeListChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("file") && context.Command.Contains("show"))
        {
            PullFiles.ShowFiles(NavigationStackTree.TopDirectory().Path);
        }

        Next?.Handle(context);
    }
}