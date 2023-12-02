namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public class FileShowChain : BaseChain
{
    public override void Handle(Context context, Invoker invoker)
    {
        Next?.Handle(context, invoker);
    }
}