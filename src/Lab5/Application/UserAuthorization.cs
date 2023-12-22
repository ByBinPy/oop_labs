using CLI;
using Ports;

namespace Application;

public class UserAuthorization : ICommand
{
    public async Task ExecuteAsync(Context context)
    {
        await Task.Delay(100).ConfigureAwait(false);
    }
}