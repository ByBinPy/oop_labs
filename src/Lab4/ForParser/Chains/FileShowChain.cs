namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileShowChain : BaseChain
{
    public override void Handle(Context context)
    {
        Next?.Handle(context);
    }
}