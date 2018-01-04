namespace StrategyPattern
{
    public class AustraliaProductionCostStrategy : IProductionCostCalculatorService
    {
        public decimal Calculate(Product order)
        {
            order.ProductionCost = order.Price * 0.2m;
            return order.ProductionCost;
        }
    }
}