using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileMoveChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("file") && context.Command.Contains("move") && context.Command.Count() == 4)
        {
            var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(context.Command.ElementAt(2)));
            if (file.Exists)
            {
                file.MoveTo(FileSystem.Path + PathSelector.SelectPath(context.Command.ElementAt(3)));
            }
        }

        Next?.Handle(context);
    }
}