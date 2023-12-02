using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class FileRenameCommand : ICommand
{
    private Context _context;

    public FileRenameCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        var file = new FileInfo(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(2)));
        if (file.Exists)
            File.Move(file.FullName ?? string.Empty, file.FullName?[..^file.Name.Length] + _context.Command.ElementAt(3) ?? string.Empty);
    }
}