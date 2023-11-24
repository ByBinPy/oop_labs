namespace Itmo.ObjectOrientedProgramming.Lab4;

public abstract class BaseChain : IChane
{
    protected IChane? Next { get; set; }

    public IChane AddNext(IChane link)
    {
        return Next == null ? Next = link : Next.AddNext(link);
    }

    public abstract void Handle(Context context);
}