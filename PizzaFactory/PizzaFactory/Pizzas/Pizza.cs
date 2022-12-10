namespace PizzaFactory.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; }

    public List<string> Toppings = new List<string>();

    // more like a template method
    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Baking...");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting...");
    }

    public void Box()
    {
        Console.WriteLine("Boxing...");
    }
}