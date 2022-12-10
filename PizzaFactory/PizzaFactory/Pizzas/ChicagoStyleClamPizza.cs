
using PizzaFactory.Ingredient;

namespace PizzaFactory.Pizzas;

public class ChicagoStyleClamPizza : Pizza
{
    public IPizzaIngredientFactory IngredientFactory { get; set; }
    
    public ChicagoStyleClamPizza(IPizzaIngredientFactory factory)
    {
        IngredientFactory = factory;

        Name = "Chicago Style Clam Pizza";
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