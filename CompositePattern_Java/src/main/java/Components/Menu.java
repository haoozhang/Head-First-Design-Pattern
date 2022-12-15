package Components;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Menu extends MenuComponent
{
    public List<MenuComponent> Components;

    public String Name;

    public String Description;

    public Menu(String name, String description)
    {
        Components = new ArrayList<>();
        Name = name;
        Description = description;
    }

    @Override
    public void Add(MenuComponent component)
    {
        Components.add(component);
    }

    @Override
    public void Remove(MenuComponent component)
    {
        Components.remove(component);
    }

    @Override
    public MenuComponent GetChild(int i)
    {
        return Components.get(i);
    }

    @Override
    public void Print()
    {
        System.out.println("Name: " + Name);
        System.out.println("Description: " + Description);
        System.out.println("============");

        Iterator iterator = CreateIterator();
        while (iterator.hasNext())
        {
            var component = (MenuComponent) iterator.next();
            component.Print();
        }
    }

    @Override
    public Iterator CreateIterator()
    {
        return Components.iterator();
    }
}
