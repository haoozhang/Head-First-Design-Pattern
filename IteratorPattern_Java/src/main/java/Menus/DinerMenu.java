package Menus;

import Iterators.DinerMenuIterator;
import java.util.Iterator;

public class DinerMenu implements Menu
{
    private static final int MAX_ITEMS = 6;

    private int NumberOfItems = 0;

    public MenuItem[] MenuItems;

    public DinerMenu()
    {
        MenuItems = new MenuItem[MAX_ITEMS];

        AddItem("Soup of day", "potato salard", true, 3.29);
        AddItem("Hot dog", "hot dog with cheese", false, 4.99);
        AddItem("Vegetarian BLT", "tomato with wheat", true, 2.49);
    }

    public void AddItem(String name, String description, boolean vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);
        if (NumberOfItems >= MAX_ITEMS)
        {
            System.out.println("Menu is full! Can't add more items!");
        }
        else
        {
            MenuItems[NumberOfItems++] = menuItem;
        }
    }

    public Iterator CreateIterator()
    {
        return new DinerMenuIterator(MenuItems);
    }
}