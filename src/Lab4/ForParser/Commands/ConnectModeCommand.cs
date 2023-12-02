using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class ConnectModeCommand : ICommand
{
    private readonly Context _context;

    public ConnectModeCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        FileSystem.ChangeMode(_context.Command.ElementAt(3));
    }
}