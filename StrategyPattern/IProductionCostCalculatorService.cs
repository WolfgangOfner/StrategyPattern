namespace StrategyPattern
{
    public interface IProductionCostCalculatorService
    {
        decimal Calculate(Product product);
    }
}