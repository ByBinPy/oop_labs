using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public static class PathSelector
{
    public static string SelectPath(string path)
    {
        if (IsAbsolutePath(path))
            return path.Substring(FileSystem.Path.Length);
        if (IsRelativePath(path))
            return path;
        return string.Empty;
    }

    private static bool IsRelativePath(string path)
    {
        if (path.Contains(FileSystem.Path, StringComparison.CurrentCulture))
            return false;
        if (System.IO.Directory.Exists(FileSystem.Path + path) || System.IO.File.Exists(FileSystem.Path + path))
            return true;
        return false;
    }

    private static bool IsAbsolutePath(string path)
    {
        if (path.Contains(FileSystem.Path, StringComparison.CurrentCulture)
            && (System.IO.Directory.Exists(FileSystem.Path + path) ||
                System.IO.File.Exists(FileSystem.Path + path)))
            return true;
        return false;
    }
}