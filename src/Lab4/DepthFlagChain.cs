using System;
using System.Globalization;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class DepthFlagChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("tree") && context.Command.Contains("list"))
        {
            if (context.Command.Contains("-d"))
            {
                ShowWithDepth(
                    NavigationStackTree.TopDirectory().Path,
                    int.Parse(context.Command.ElementAt(3), CultureInfo.InvariantCulture));
            }
        }
        else
        {
            Next?.Handle(context);
        }
    }

    private static void ShowWithDepth(string directoryPath, int depth)
    {
        if (depth > 1)
        {
            foreach (string i in System.IO.Directory.GetDirectories(FileSystemPath.SystemPath + directoryPath))
            {
                ShowWithDepth(i, depth - 1);
                PullFiles.ShowFiles(directoryPath);
            }
        }
    }
}