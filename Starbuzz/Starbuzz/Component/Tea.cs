namespace Starbuzz.Component;

public class Tea : IBeverage
{
    public string Description { get; set; } = "Tea";

    public double Cost()
    {
        return 19.99;
    }
}