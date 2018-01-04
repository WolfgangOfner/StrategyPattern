using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Computer",
                    Price = 299.99m
                },
                new Product
                {
                    Name = "Shampoo",
                    Price = 1.49m
                },
                new Product
                {
                    Name = "Car",
                    Price = 24999.99m
                }
            };

            var chinaProductionCostStrategy = new ChinaProductionCostStrategy();
            var usaProductionCostStrategy = new UsaProductionCostStrategy();
            var australiaProductionCostStrategy = new AustraliaProductionCostStrategy();
            var productionCostCalculatorService = new ProductionCostCalculatorService();

            Console.WriteLine($"The production costs for {products[0].Name} are {productionCostCalculatorService.CalculateProductionCost(products[0], chinaProductionCostStrategy)}");
            Console.WriteLine($"The production costs for {products[1].Name} are {productionCostCalculatorService.CalculateProductionCost(products[1], australiaProductionCostStrategy)}");
            Console.WriteLine($"The production costs for {products[2].Name} are {productionCostCalculatorService.CalculateProductionCost(products[2], usaProductionCostStrategy)}");

            Console.ReadKey();
        }
    }
}