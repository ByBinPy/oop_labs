using System.Globalization;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class DepthFlagCommand : ICommand
{
    private Context _context;

    public DepthFlagCommand(Context context)
    {
        _context = context;
    }

    public void Execute()
    {
        ShowWithDepth(
            FileSystem.Path + NavigationStackTree.TopDirectory()?.Path ?? string.Empty,
            int.Parse(_context.Command.ElementAt(3), CultureInfo.InvariantCulture));
    }

    private static void ShowWithDepth(string subPath, int depth, int index = 1)
    {
        if (index < depth)
        {
            foreach (string i in System.IO.Directory.GetDirectories(subPath))
            {
                PullFiles.ShowEntries(i, index + 1);
                ShowWithDepth(i, depth, index + 1);
            }
        }
    }
}