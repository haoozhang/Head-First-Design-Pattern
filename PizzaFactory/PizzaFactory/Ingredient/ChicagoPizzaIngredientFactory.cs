using PizzaFactory.Cheeses;
using PizzaFactory.Clams;
using PizzaFactory.Doughs;

namespace PizzaFactory.Ingredient;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ChicagoDough();
    }
    
    public Cheese CreateCheese()
    {
        return new ChicagoCheese();
    }

    public Clam CreateClam()
    {
        return new ChicagoClam();
    }
}