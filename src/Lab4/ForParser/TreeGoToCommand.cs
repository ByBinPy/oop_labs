using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class TreeGoToCommand : ICommand
{
    private Context _context;

    public TreeGoToCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        NavigationStackTree.PushDirectory(new Directory(PathSelector.SelectPath(_context.Command.ElementAt(2))));
    }
}