using PizzaFactory.Ingredient;

namespace PizzaFactory.Pizzas;

public class NyStyleClamPizza : Pizza
{
    public IPizzaIngredientFactory IngredientFactory { get; set; }
    
    public NyStyleClamPizza(IPizzaIngredientFactory factory)
    {
        IngredientFactory = factory;

        Name = "NY Style Clam Pizza";
        Toppings.Add(IngredientFactory.CreateCheese().Name);
        Toppings.Add(IngredientFactory.CreateClam().Name);
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Console.WriteLine("Adding " + IngredientFactory.CreateDough().Name);
        Console.WriteLine("Adding Sauce...");
        Console.Write("Adding Toppings: ");
        foreach (var topping in Toppings)
        {
            Console.Write(topping + " ");
        }
        Console.WriteLine();
    }
}