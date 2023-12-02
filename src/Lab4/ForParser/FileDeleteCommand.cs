using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class FileDeleteCommand : ICommand
{
    private Context _context;

    public FileDeleteCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(2)));
        if (file.Exists)
            file.Delete();
    }
}