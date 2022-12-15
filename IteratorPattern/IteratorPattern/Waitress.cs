using IteratorPattern.Iterators;
using IteratorPattern.Menus;

namespace IteratorPattern;

public class Waitress
{
    public IMenu PancakeHouseMenu { get; set; }

    public IMenu DinerMenu { get; set; }

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
    {
        PancakeHouseMenu = pancakeHouseMenu;
        DinerMenu = dinerMenu;
    }

    public void PrintMenu()
    {
        IIterator pancakeHouseIterator = PancakeHouseMenu.CreateIterator();
        IIterator dinerIterator = DinerMenu.CreateIterator();

        Console.WriteLine("==> Breakfast");
        PrintMenu(pancakeHouseIterator);
        Console.WriteLine("==> Lunch");
        PrintMenu(dinerIterator);
    }

    private void PrintMenu(IIterator iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = iterator.Next() as MenuItem;
            Console.WriteLine("Name: " + menuItem?.Name);
            Console.WriteLine("Description: " + menuItem?.Description);
            Console.WriteLine("Price: " + menuItem?.Price);
        }
    }
}