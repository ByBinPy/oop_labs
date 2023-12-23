#pragma warning disable CA1822
using Application;
using Application.Exceptions;
using CLI.Chains;
using Port.Ports;

namespace CLI;

public abstract class BaseChain : IChain
{
    protected IChain? Next { get; private set; }

    public IChain AddNext(IChain chain)
    {
        return Next == null ? Next = chain : Next.AddNext(chain);
    }

    public void Handle(IInvoker invoker)
    {
        throw new InvalidInputException();
    }

    public abstract void Handle(Context context, IInvoker invoker);
}