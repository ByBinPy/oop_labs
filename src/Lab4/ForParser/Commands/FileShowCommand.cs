using System.IO;
using System.Linq;
using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class FileShowCommand : ICommand
{
    private Context _context;

    public FileShowCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        var dataShow = new DataShow();
        byte[] buffer = File.ReadAllBytes(FileSystem.Path + PathSelector.SelectPath(_context.Command.ElementAt(2)));
        dataShow.DisplayWithMode(_context.Command.ElementAt(4));
        dataShow.Show($"Data from this file + \n + {Encoding.Default.GetString(buffer)}");
    }
}