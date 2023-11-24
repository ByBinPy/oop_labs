using System;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ConnectChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("connect"))
            FileSystem.ChangePath(context.Command.ElementAt(1));

        Next?.Handle(context);
    }
}