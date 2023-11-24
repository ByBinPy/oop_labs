using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class NavigationStackTree
{
    private static readonly Stack<Directory> Stack = new Stack<Directory>();

    public static void PushDirectory(Directory directory)
    {
        if (directory.Path.Length > 0)
            Stack.Push(directory);
    }

    public static Directory PopDirectory() => Stack.Pop();

    public static Directory? TopDirectory() => Stack.Count == 0 ? null : Stack.Peek();
}