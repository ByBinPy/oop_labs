using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class FileCopyCommand : ICommand
{
    private Context _context;

    public FileCopyCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(2)));
        if (file.Exists && System.IO.Directory.Exists(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(3))))
            file.CopyTo(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(3)));
    }
}