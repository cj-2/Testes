using TestesDI.Strategies;

namespace TestesDI;

public class ClasseComum (IList<IStrategy> strategies)
{
    public void Handle()
    {
        foreach (var strategy in strategies)
        {
            strategy.Run();
        }
    }
}