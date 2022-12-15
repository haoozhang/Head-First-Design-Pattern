import Components.Menu;
import Components.MenuComponent;
import Components.MenuItem;
import java.util.Iterator;
import java.util.Stack;

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
        System.out.println("Vegetarian Menu: ");

        Stack<MenuComponent> stack = new Stack<MenuComponent>();
        stack.push(AllMenus);

        while (!stack.empty())
        {
            var element = stack.pop();

            Iterator iterator = element.CreateIterator();
            while (iterator.hasNext())
            {
                var component = (MenuComponent) iterator.next();
                if (component instanceof Menu)
                {
                    stack.push(component);
                }
                else if (component instanceof MenuItem && ((MenuItem) component).isVegetarian())
                {
                    component.Print();
                }
            }
        }
    }
}