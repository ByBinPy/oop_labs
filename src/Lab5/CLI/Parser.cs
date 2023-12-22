namespace CLI;

public class Parser : IParser
{
    public async Task ParseAsync()
    {
        await Task.Delay(100).ConfigureAwait(false);
    }
}