using Application.Chains;
using CLI.Chains;
using Port.Ports;

namespace Application;

public class AdminParser : IParser
{
    private IChain _changeStateChain = new ChangeStateChain();
    private IChain _showHistoryAdmin = new ShowHistoryAdminChain();
    private IChain _adminShowChain = new AdminShowChain();
    public AdminParser()
    {
        _changeStateChain.AddNext(_showHistoryAdmin);
        _showHistoryAdmin.AddNext(_adminShowChain);
    }

    public async Task ParseAsync(Context context)
    {
        var invoker = new Invoker(new BaseCommand());
        _changeStateChain.Handle(context, invoker);
        await invoker.ExecuteAsync().ConfigureAwait(false);
    }
}