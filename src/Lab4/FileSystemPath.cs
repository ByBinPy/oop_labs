namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class FileSystemPath
{
    public static string SystemPath { get; private set; } = string.Empty;

    public static void ChangeSystemPath(string fileSystemPath)
    {
        if (fileSystemPath != SystemPath)
            SystemPath = fileSystemPath;
    }
}