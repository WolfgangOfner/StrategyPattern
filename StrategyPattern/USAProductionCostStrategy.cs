namespace StrategyPattern
{
    public class UsaProductionCostStrategy : IProductionCostCalculatorService
    {
        public decimal Calculate(Product order)
        {
            order.ProductionCost = order.Price * 0.22m;
            return order.ProductionCost;
        }
    }
}