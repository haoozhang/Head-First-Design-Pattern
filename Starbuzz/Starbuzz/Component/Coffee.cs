namespace Starbuzz.Component;

public class Coffee : IBeverage
{
    public string Description { get; set; } = "Coffee";

    public double Cost()
    {
        return 6.66;
    }
}