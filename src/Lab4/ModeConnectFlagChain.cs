using System;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ModeConnectFlagChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("-m"))
            throw new NotImplementedException();

        Next?.Handle(context);
    }
}