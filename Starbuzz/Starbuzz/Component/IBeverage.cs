namespace Starbuzz.Component;

public interface IBeverage
{
    public string Description { get; }

    public double Cost();
}