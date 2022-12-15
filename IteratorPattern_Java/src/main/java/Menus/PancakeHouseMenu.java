package Menus;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class PancakeHouseMenu implements Menu
{
    public List<MenuItem> MenuItems;

    public PancakeHouseMenu()
    {
        MenuItems = new ArrayList<>();

        AddItem("Regular Pancake Breakfast", "fired eggs, sausage", false, 2.99);
        AddItem("Blueberry Pancakes", "fresh blueberry", true, 1.99);
        AddItem("K&B Breakfast", "scrambled eggs, toast", true, 3.99);
    }

    public void AddItem(String name, String description, boolean vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);
        MenuItems.add(menuItem);
    }

    public Iterator CreateIterator()
    {
        return MenuItems.iterator();
    }
}
