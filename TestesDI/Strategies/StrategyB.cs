namespace TestesDI.Strategies;

public class StrategyB: IStrategy
{
    public StrategyType Type { get; } = StrategyType.B;
    
    public void Run()
    {
        Console.WriteLine("B");
    }
}