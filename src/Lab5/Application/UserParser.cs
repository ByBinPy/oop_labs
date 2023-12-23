using CLI;
using CLI.Chains;

namespace Application.Chains;

public class UserParser : IParser
{
    private IChain _userRefillChain = new UserRefillChain();
    private IChain _userShowChain = new UserShowChain();
    private IChain _userHistoryChain = new UserHistoryChain();
    private IChain _changeStateChain = new ChangeStateChain();
    public UserParser()
    {
        _userRefillChain.AddNext(_userShowChain);
        _userShowChain.AddNext(_userHistoryChain);
        _userHistoryChain.AddNext(_changeStateChain);
    }

    public async Task ParseAsync(Context context)
    {
        IInvoker invoker = new Invoker(new BaseCommand());
        _userRefillChain.Handle(context, invoker);
        await invoker.ExecuteAsync().ConfigureAwait(false);
    }
}