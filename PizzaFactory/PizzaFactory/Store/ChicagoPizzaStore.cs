using PizzaFactory.Ingredient;
using PizzaFactory.Pizzas;

namespace PizzaFactory.Store;

public class ChicagoPizzaStore : PizzaStoreFactory
{
    public IPizzaIngredientFactory IngredientFactory;
    
    public ChicagoPizzaStore(IPizzaIngredientFactory factory)
    {
        IngredientFactory = factory;
    }
    
    protected override Pizza CreatePizza(string type)
    {
        switch (type)
        {
            case "cheese":
                return new ChicagoStyleCheesePizza(IngredientFactory);
            case "clam":
                return new ChicagoStyleClamPizza(IngredientFactory);
            case "veggie":
                return new ChicagoStyleVeggiePizza(IngredientFactory);
            default:
                return new ChicagoStyleCheesePizza(IngredientFactory);
        }
    }
}