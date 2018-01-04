namespace StrategyPattern
{
    public class ChinaProductionCostStrategy : IProductionCostCalculatorService
    {
        public decimal Calculate(Product order)
        {
            order.ProductionCost = order.Price * 0.1m;
            return order.ProductionCost;
        }
    }
}