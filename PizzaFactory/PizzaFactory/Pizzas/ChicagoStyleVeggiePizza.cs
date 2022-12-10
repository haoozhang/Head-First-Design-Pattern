
using PizzaFactory.Ingredient;

namespace PizzaFactory.Pizzas;

public class ChicagoStyleVeggiePizza : Pizza
{
    public IPizzaIngredientFactory IngredientFactory { get; set; }
    
    public ChicagoStyleVeggiePizza(IPizzaIngredientFactory factory)
    {
        IngredientFactory = factory;

        Name = "Chicago Style Veggie Pizza";
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