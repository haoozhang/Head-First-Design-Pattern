using CompositePattern.Components;
using CompositePattern.Iterators;

namespace CompositePattern;

public class Waitress
{
    public MenuComponent AllMenus;

    public Waitress(MenuComponent allMenus)
    {
        AllMenus = allMenus;
    }

    public void PrintMenu()
    {
        AllMenus.Print();
    }

    public void PrintVegetarianMenu()
    {
        Console.WriteLine("Vegetarian Menu: ");

        Stack<MenuComponent> stack = new Stack<MenuComponent>();
        stack.Push(AllMenus);

        while (stack.Count != 0)
        {
            var element = stack.Pop();
            
            IIterator iterator = element.CreateIterator();
            while (iterator.HasNext())
            {
                var component = iterator.Next() as MenuComponent;
                if (component is Menu)
                {
                    stack.Push(component);
                }
                else if (component is MenuItem item && item.Vegetarian)
                {
                    item.Print();
                }
            }
        }
    }
}