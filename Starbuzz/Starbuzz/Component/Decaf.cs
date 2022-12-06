namespace Starbuzz.Component;

public class Decaf : IBeverage
{
    public string Description { get; set; } = "Decaf";

    public double Cost()
    {
        return 9.99;
    }
}