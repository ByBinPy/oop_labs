using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class PullFiles
{
    public static void ShowFiles(string subDirectory)
    {
        string[] files = System.IO.Directory.GetFiles(FileSystemPath.SystemPath + subDirectory);

        foreach (string i in files)
        {
            Console.WriteLine(i);
        }
    }
}