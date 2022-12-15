namespace TemplateMethodPattern;

public class Coffee : CaffeineBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter....");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk....");
    }

    public override bool CustomerWantCondiments()
    {
        return false;
    }
}