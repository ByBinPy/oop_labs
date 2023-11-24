using System;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class PullFiles
{
    public static void ShowEntries(string path, int depth = 1)
    {
        string[] files = System.IO.Directory.GetFileSystemEntries(path);
        Console.WriteLine("\n" + string.Concat(Enumerable.Repeat("---", depth)) + path + "\n");
        foreach (string i in files)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("---", depth + 1)) + i[path.Length..]);
        }

        Console.WriteLine("\n");
    }
}