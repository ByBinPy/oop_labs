using System;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ConnectChane : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("connect"))
            FileSystemPath.ChangeSystemPath(context.Command.ElementAt(1));

        Next?.Handle(context);
    }
}