
using PizzaFactory.Ingredient;
using PizzaFactory.Store;

// Factory Pattern

namespace PizzaFactory
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            IPizzaIngredientFactory nyFactory = new NyPizzaIngredientFactory();
            PizzaStoreFactory nyPizzaStore = new NyPizzaStore(nyFactory);
            nyPizzaStore.OrderPizza("cheese");

            Console.WriteLine();

            IPizzaIngredientFactory chicagoFactory = new ChicagoPizzaIngredientFactory();
            PizzaStoreFactory chicagoPizzaStore = new ChicagoPizzaStore(chicagoFactory);
            chicagoPizzaStore.OrderPizza("clam");
            
        }
    }
}