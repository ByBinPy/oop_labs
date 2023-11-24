using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileDeleteChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("file") && context.Command.Contains("delete") && context.Command.Count() == 3)
        {
            var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(context.Command.ElementAt(2)));
            if (file.Exists)
                file.Delete();
        }

        Next?.Handle(context);
    }
}