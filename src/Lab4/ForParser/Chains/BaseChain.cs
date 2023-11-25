namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public abstract class BaseChain : IChane
{
    protected IChane? Next { get; private set; }

    public IChane AddNext(IChane link)
    {
        return Next == null ? Next = link : Next.AddNext(link);
    }

    public abstract void Handle(Context context);
}