using PizzaFactory.Cheeses;
using PizzaFactory.Clams;
using PizzaFactory.Doughs;

namespace PizzaFactory.Ingredient;

public class NyPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new NyDough();
    }

    public Cheese CreateCheese()
    {
        return new NyCheese();
    }

    public Clam CreateClam()
    {
        return new NyClam();
    }
}