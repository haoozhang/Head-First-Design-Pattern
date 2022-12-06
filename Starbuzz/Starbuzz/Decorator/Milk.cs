using Starbuzz.Component;

namespace Starbuzz.Decorator;

public class Milk : ICondimentDecorator
{
    public string Description
    {
        get => "Milk, " + Beverage.Description;
    }

    public IBeverage Beverage { get; set; }

    public Milk(IBeverage beverage)
    {
        Beverage = beverage;
    }
    
    public double Cost()
    {
        return Beverage.Cost() + 1.01;
    }
}