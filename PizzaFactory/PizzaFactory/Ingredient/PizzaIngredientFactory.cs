using PizzaFactory.Cheeses;
using PizzaFactory.Clams;
using PizzaFactory.Doughs;

namespace PizzaFactory.Ingredient;

// abstract factory
public interface IPizzaIngredientFactory
{
    public Dough CreateDough();
    public Cheese CreateCheese();
    public Clam CreateClam();
}