using PizzaFactory.Ingredient;

namespace PizzaFactory.Pizzas;

public class NyStyleCheesePizza : Pizza
{
    public IPizzaIngredientFactory IngredientFactory { get; set; }
    
    public NyStyleCheesePizza(IPizzaIngredientFactory factory)
    {
        IngredientFactory = factory;

        Name = "NY Style Cheese Pizza";
        Toppings.Add(IngredientFactory.CreateCheese().Name);
        Toppings.Add(IngredientFactory.CreateClam().Name);
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Console.WriteLine("Adding " + IngredientFactory.CreateDough().Name);
        Console.WriteLine("Adding Sauce...");
        Console.WriteLine("Adding Toppings: ");
        foreach (var topping in Toppings)
        {
            Console.Write(topping + " ");
        }
        Console.WriteLine();
    }
}