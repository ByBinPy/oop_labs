namespace CLI.Chains;

public interface IChain
{
    IChain AddNext(IChain chain);
    void Handle(Context context, IInvoker invoker);
}