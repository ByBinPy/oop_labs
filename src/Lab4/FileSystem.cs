namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class FileSystem
{
    private const string BaseMode = "console";
    public static string Path { get; private set; } = string.Empty;
    public static string Mode { get; private set; } = BaseMode;

    public static void ChangePath(string systemPath)
    {
        if (systemPath != Path)
            Path = systemPath;
    }

    public static void ChangeMode(string systemMode)
    {
        if (systemMode != Path)
            Path = systemMode;
    }
}