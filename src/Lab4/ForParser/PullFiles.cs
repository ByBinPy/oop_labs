using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public static class PullFiles
{
    public static void ShowEntries(string path, int depth = 1)
    {
        string[] files = System.IO.Directory.GetFileSystemEntries(path);
        var dataShow = new DataShow();
        dataShow.Show("\n" + string.Concat(Enumerable.Repeat("---", depth)) + path + "\n");
        foreach (string i in files)
        {
            dataShow.Show(string.Concat(Enumerable.Repeat("---", depth + 1)) + i[path.Length..]);
        }

        dataShow.Show("\n");
    }
}