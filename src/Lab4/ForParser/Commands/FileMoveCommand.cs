using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class FileMoveCommand : ICommand
{
    private Context _context;

    public FileMoveCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(2)));
        if (file.Exists)
        {
            file.MoveTo(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(3)));
        }
    }
}