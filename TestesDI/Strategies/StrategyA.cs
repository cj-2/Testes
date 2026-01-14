namespace TestesDI.Strategies;

public class StrategyA : IStrategy
{
    public StrategyType Type { get; } = StrategyType.A;

    public void Run()
    {
        Console.WriteLine("A");
    }
}