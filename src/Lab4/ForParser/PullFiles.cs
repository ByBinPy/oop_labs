using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Client;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public static class PullFiles
{
    private static IDataShow? _dataShow = new DataShow();

    public static void SetDataShow(IDataShow dataShow)
    {
        _dataShow = dataShow;
    }

    public static void ShowEntries(string path, int depth = 1)
    {
        string[] files = System.IO.Directory.GetFileSystemEntries(path);
        _dataShow?.Show("\n" + string.Concat(Enumerable.Repeat("---", depth)) + path + "\n");
        foreach (string i in files)
        {
            _dataShow?.Show(string.Concat(Enumerable.Repeat("---", depth + 1)) + i[path.Length..]);
        }

        _dataShow?.Show("\n");
    }
}