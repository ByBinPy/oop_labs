using System.Globalization;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class DepthFlagChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("tree") && context.Command.Contains("list"))
        {
            if (context.Command.Contains("-d"))
            {
                ShowWithDepth(
                    FileSystem.Path + NavigationStackTree.TopDirectory()?.Path ?? string.Empty,
                    int.Parse(context.Command.ElementAt(3), CultureInfo.InvariantCulture));
            }
        }
        else
        {
            Next?.Handle(context);
        }
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