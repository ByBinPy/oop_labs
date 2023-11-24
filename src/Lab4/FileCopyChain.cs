using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileCopyChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("file") && context.Command.Contains("copy") && context.Command.Count() == 4)
        {
            var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(context.Command.ElementAt(2)));
            if (file.Exists && System.IO.Directory.Exists(FileSystem.Path + PathSelector.SelectPath(context.Command.ElementAt(3))))
                file.CopyTo(FileSystem.Path + PathSelector.SelectPath(context.Command.ElementAt(3)));
        }

        Next?.Handle(context);
    }
}