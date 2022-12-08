using Starbuzz.Component;

namespace Starbuzz.Decorator;

public class Soy : ICondimentDecorator
{
    public string Description
    {
        get => "Soy, " + Beverage.Description;
    }

    public IBeverage Beverage { get; set; }

    public Soy(IBeverage beverage)
    {
        Beverage = beverage;
    }
    
    public double Cost()
    {
        return Beverage.Cost() + 3.01;
    }
}