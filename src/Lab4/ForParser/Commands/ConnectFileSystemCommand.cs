using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class ConnectFileSystemCommand : ICommand
{
    private readonly Context _context;

    public ConnectFileSystemCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        FileSystem.ChangePath(_context.Command.ElementAt(1));
    }
}