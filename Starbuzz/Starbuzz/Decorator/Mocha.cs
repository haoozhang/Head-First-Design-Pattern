using Starbuzz.Component;

namespace Starbuzz.Decorator;

public class Mocha : ICondimentDecorator
{
    public string Description
    {
        get => "Mocha, " + Beverage.Description;
    }

    public IBeverage Beverage { get; set; }

    public Mocha(IBeverage beverage)
    {
        Beverage = beverage;
    }
    
    public double Cost()
    {
        return Beverage.Cost() + 2.01;
    }
}