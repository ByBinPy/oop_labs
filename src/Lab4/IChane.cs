namespace Itmo.ObjectOrientedProgramming.Lab4;

public interface IChane
{
    IChane AddNext(IChane link);
    void Handle(Context context);
}