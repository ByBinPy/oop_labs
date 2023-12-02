namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

public interface IChane
{
    IChane AddNext(IChane link);
    void Handle(Context context, Invoker invoker);
}