using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class PathSelector
{
    public static string SelectPath(string path)
    {
        if (IsAbsolutePath(path))
            return path.Substring(FileSystemPath.SystemPath.Length);
        if (IsRelativePath(path))
            return path;
        return string.Empty;
    }

    private static bool IsRelativePath(string path)
    {
        if (path.Contains(FileSystemPath.SystemPath, StringComparison.CurrentCulture))
            return false;
        if (System.IO.Directory.Exists(FileSystemPath.SystemPath + path))
            return true;
        return false;
    }

    private static bool IsAbsolutePath(string path)
    {
        if (path.Contains(FileSystemPath.SystemPath, StringComparison.CurrentCulture)
            && System.IO.Directory.Exists(FileSystemPath.SystemPath + path))
            return true;
        return false;
    }
}