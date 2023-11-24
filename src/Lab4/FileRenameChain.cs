using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileRenameChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("file") && context.Command.Contains("rename") && context.Command.Count() == 4)
        {
            var file = new FileInfo(FileSystemPath.SystemPath + PathSelector.SelectPath(context.Command.ElementAt(2)));
            if (file.Exists)
                File.Move(file.Directory + file.Name, file.Directory + context.Command.ElementAt(3));
        }

        Next?.Handle(context);
    }
}