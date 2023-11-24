using System;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class TreeGoToChane : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("tree") && context.Command.Contains("goto") && context.Command.Count() == 3)
        {
            NavigationStackTree.PushDirectory(new Directory(PathSelector.SelectPath(context.Command.ElementAt(2))));
        }
        else
        {
            Next?.Handle(context);
        }
    }
}