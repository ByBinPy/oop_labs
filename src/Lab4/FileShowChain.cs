using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileShowChain : BaseChain
{
    public override void Handle(Context context)
    {
        if (context.Command.Contains("file") && context.Command.Contains("show"))
        {
            byte[] buffer = File.ReadAllBytes(FileSystemPath.SystemPath + PathSelector.SelectPath(context.Command.ElementAt(2)));

            Console.WriteLine($"Data from this file + \n + {Encoding.Default.GetString(buffer)}");
        }
    }
}