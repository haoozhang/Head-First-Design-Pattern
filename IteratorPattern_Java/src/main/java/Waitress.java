import Menus.Menu;
import Menus.MenuItem;
import java.util.Iterator;

public class Waitress
{
    public Menu PancakeHouseMenu;

    public Menu DinerMenu;

    public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
    {
        PancakeHouseMenu = pancakeHouseMenu;
        DinerMenu = dinerMenu;
    }

    public void PrintMenu()
    {
        Iterator pancakeHouseIterator = PancakeHouseMenu.CreateIterator();
        Iterator dinerIterator = DinerMenu.CreateIterator();

        System.out.println("==> Breakfast");
        PrintMenu(pancakeHouseIterator);
        System.out.println("==> Lunch");
        PrintMenu(dinerIterator);
    }

    private void PrintMenu(Iterator iterator)
    {
        while (iterator.hasNext())
        {
            var menuItem = (MenuItem) iterator.next();
            System.out.println("Name: " + menuItem.Name);
            System.out.println("Description: " + menuItem.Description);
            System.out.println("Price: " + menuItem.Price);
        }
    }
}
