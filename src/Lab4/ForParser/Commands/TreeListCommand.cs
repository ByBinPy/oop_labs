namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class TreeListCommand : ICommand
{
    public void Execute()
    {
        PullFiles.ShowEntries(FileSystem.Path + (NavigationStackTree.TopDirectory()?.Path ?? string.Empty));
    }
}