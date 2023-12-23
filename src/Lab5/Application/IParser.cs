using CLI;

namespace Application;

public interface IParser
{
    Task ParseAsync(Context context);
}