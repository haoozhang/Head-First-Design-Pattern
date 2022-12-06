
using Starbuzz.Component;
using Starbuzz.Decorator;

// Decorator Pattern

namespace Starbuzz
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new Tea();
            Console.WriteLine($"{beverage.Description}'s cost: {beverage.Cost()}");

            beverage = new Milk(beverage);
            beverage = new Milk(beverage);
            beverage = new Soy(beverage);
            Console.WriteLine($"{beverage.Description}'s cost: {beverage.Cost()}");
        }
    }
}