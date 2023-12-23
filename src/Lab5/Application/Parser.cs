using Application.Chains;
using CLI;

namespace Application;

public class Parser : IParser
{
    public static IParser State { get; private set; } = new UserParser();

    public static void ChangeState()
    {
        State = State is UserParser ? new AdminParser() : new UserParser();
    }

    public async Task ParseAsync(Context context)
    {
        await State.ParseAsync(context).ConfigureAwait(false);
    }
}