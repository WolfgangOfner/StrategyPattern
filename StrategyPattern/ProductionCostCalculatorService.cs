namespace StrategyPattern
{
    public class ProductionCostCalculatorService
    {
        public decimal CalculateProductionCost(Product product, IProductionCostCalculatorService productionCostCalculatorService)
        {
            return productionCostCalculatorService.Calculate(product);
        }
    }
}