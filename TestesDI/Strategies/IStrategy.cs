namespace TestesDI.Strategies;

public enum StrategyType
{
    A,
    B
}

public interface IStrategy
{
    public StrategyType Type { get; }
    public void Run();
}