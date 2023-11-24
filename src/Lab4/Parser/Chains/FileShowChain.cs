namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileShowChain : BaseChain
{
    public override void Handle(Context context)
    {
        Next?.Handle(context);
    }
}