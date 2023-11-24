using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileRenameChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("file") && context.Command.Contains("rename") && context.Command.Count() == 4)
        {
            var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(context.Command.ElementAt(2)));
            if (file.Exists)
                File.Move(file.FullName ?? string.Empty, file.FullName?[..^file.Name.Length] + context.Command.ElementAt(3) ?? string.Empty);
        }

        Next?.Handle(context);
    }
}