using PizzaFactory.Pizzas;

namespace PizzaFactory.Store;

public abstract class PizzaStoreFactory
{
    // factory method
    protected abstract Pizza CreatePizza(string type);

    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}