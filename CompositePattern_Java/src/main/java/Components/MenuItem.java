package Components;

import Iterators.NullIterator;
import java.util.Iterator;

public class MenuItem extends MenuComponent
{
    public String Name;

    public String Description;

    public boolean Vegetarian;

    public double Price;

    public MenuItem(String name, String description, boolean vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }

    public boolean isVegetarian() {
        return Vegetarian;
    }

    @Override
    public void Add(MenuComponent component)
    {
        throw new UnsupportedOperationException("Can't add for menu item!");
    }

    @Override
    public void Remove(MenuComponent component)
    {
        throw new UnsupportedOperationException("Can't add for menu item!");
    }

    @Override
    public MenuComponent GetChild(int i)
    {
        throw new UnsupportedOperationException("Can't add for menu item!");
    }

    @Override
    public void Print()
    {
        System.out.println("Name: " + Name);
        System.out.println("Description: " + Description);
        System.out.println("Price: " + Price);
    }

    @Override
    public Iterator CreateIterator()
    {
        return new NullIterator();
    }
}