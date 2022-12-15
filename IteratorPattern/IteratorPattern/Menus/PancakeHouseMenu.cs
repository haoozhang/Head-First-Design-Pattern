using IteratorPattern.Iterators;

namespace IteratorPattern.Menus;

public class PancakeHouseMenu : IMenu
{
    public List<MenuItem> MenuItems { get; set; }

    public PancakeHouseMenu()
    {
        MenuItems = new List<MenuItem>();

        AddItem("Regular Pancake Breakfast", "fired eggs, sausage", false, 2.99);
        AddItem("Blueberry Pancakes", "fresh blueberry", true, 1.99);
        AddItem("K&B Breakfast", "scrambled eggs, toast", true, 3.99);
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);
        MenuItems.Add(menuItem);
    }

    public IIterator CreateIterator()
    {
        return new PancakeHouseIterator(MenuItems);
    }
}