using PizzaFactory.Ingredient;
using PizzaFactory.Pizzas;

namespace PizzaFactory.Store;

public class NyPizzaStore : PizzaStoreFactory
{
    public IPizzaIngredientFactory IngredientFactory;
    
    public NyPizzaStore(IPizzaIngredientFactory factory)
    {
        IngredientFactory = factory;
    }
    
    protected override Pizza CreatePizza(string type)
    {
        switch (type)
        {
            case "cheese":
                return new NyStyleCheesePizza(IngredientFactory);
            case "clam":
                return new NyStyleClamPizza(IngredientFactory);
            case "veggie":
                return new NyStyleVeggiePizza(IngredientFactory);
            default:
                return new NyStyleCheesePizza(IngredientFactory);
        }
    }
}